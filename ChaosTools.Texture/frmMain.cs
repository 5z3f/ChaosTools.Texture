using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.ComponentModel;

using ChaosLib.D3D;
using CBinaryTexture = ChaosLib.D3D.Structures.CBinaryTexture;
using CTextureAnimation = ChaosLib.D3D.Structures.CTextureAnimation;
using TextureFlag = ChaosLib.D3D.Structures.TextureFlag;
using ChaosTools.Texture.Properties;

namespace ChaosTools.Texture
{
    public partial class frmMain : Form
    {
        public CTexture Texture = new CTexture();
        public Bitmap[] OriginalBitmapFrames = null;

        private int CursorX = 0, CursorY = 0;
        private int IconX = 0, IconY = 0;

        // animation variables
        private readonly Timer AnimationTimer = new Timer();

        private int CurrentFrameID = 0;
        private string CurrentFileName = string.Empty;

        // control booleans
        private bool IsFileLoaded = false;
        private bool ShowEditBox = true;
        private bool ShowFrameBox = false;
        private bool ShowFlagBox = false;

        // icon mode variables
        private bool IconMode = false;
        private int IconsCreated = 0;

        // -- icon file, offset
        private int IconOffset = 32; // default
        private Dictionary<string, int> IconOffsets = new Dictionary<string, int>
        {
            { "ItemBtn",            32 },
            { "ItemCollectionBtn",  60 },
            { "SkillBtn",           32 },
            { "SkillBtnD",          32 },
            { "ActionBtn",          32 },
            { "QuestBtn",           32 },
            { "RemissionBtn",       32 },
            { "GSymbolBtn",         32 },
            { "GBackBtn",           32 },
            { "EventBtn",           32 },
            { "ComboBtn",           50 },
        };

        // supported file signatures
        private Dictionary<string, byte[]> FileSignatures = new Dictionary<string, byte[]>
        {
            { "JPG",    new byte[] { 0xFF, 0xD8, 0xFF }},
            { "JPEG",   new byte[] { 0x4A, 0x46, 0x49, 0x46 }},
            { "TEX",    new byte[] { 0x54, 0x56, 0x45, 0x52 }},
            { "PNG",    new byte[] { 0x89, 0x50, 0x4E, 0x47 }},
            { "GIF87",  new byte[] { 0x47, 0x49, 0x46, 0x38, 0x37 }},
            { "GIF89",  new byte[] { 0x47, 0x49, 0x46, 0x38, 0x39 }},
            { "TGA",    new byte[] { 0x54, 0x52, 0x55, 0x45, 0x56, 0x49, 0x53, 0x49 }},
            { "BMP",    new byte[] { 0x42, 0x4D }},
            { "DDS",    new byte[] { 0x44, 0x44, 0x53, 0x20 } }
        };

        // colorizing variables
        private Color SelectedColor = Color.Black;

        public frmMain(string fp)
        {
            InitializeComponent();

            // callback
            DragEnter += new DragEventHandler(frmMain_DragEnter);
            DragDrop += new DragEventHandler(frmMain_DragDrop);
            AnimationTimer.Tick += AnimationTimer_Tick;
            bgwExtractFrames.DoWork += bgwExtractFrames_DoWork;
            bgwExtractFrames.RunWorkerCompleted += bgwExtractFrames_RunWorkerCompleted;
            bgwExtractFrames.ProgressChanged += bgwExtractFrames_ProgressChanged;
            KeyDown += new KeyEventHandler(frmMain_KeyDown);

            KeyPreview = true;

            // set double buffer
            SetDoubleBuffered(pTexture);
            SetDoubleBuffered(pbTexture);

            // create transparent background
            pTexture.BackgroundImage = CreateTransparentBackground(size: 10);

            // resize picturebox to center
            pbTexture.Left = (pTexture.Width - pbTexture.Width) / 2;
            pbTexture.Top = (pTexture.Height - pbTexture.Height) / 2;

            // set default box visibility
            pEditBox.Visible = ShowEditBox;
            lvFrames.Visible = ShowFrameBox;
            pFlagBox.Visible = ShowFlagBox;

            // draw default select color
            DrawSelectedColor();

            // load lc texture flags
            var texflag = from i in Enum.GetNames(typeof(TextureFlag)) select i;
            clbFlag.Items.AddRange(texflag.ToArray());

            if (fp != string.Empty)
                ReadFiles(fp, sf: true);
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case (Keys.Add or Keys.Subtract):
                    if (e.Control)  SetFrameDuration(increase: e.KeyCode is Keys.Add);
                    else            SetFrame(increase: e.KeyCode is Keys.Add);
                    break;

                case Keys.Space:
                    ChangeAnimationState();
                    break;
            }
        }

        private void frmMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void frmMain_DragDrop(object sender, DragEventArgs e)
        {
            string[] f = (string[])e.Data.GetData(DataFormats.FileDrop);
            ReadFiles(f);
        }


        private dynamic ExtractFrameInfo(string fp, List<Bitmap> lbmp)
        {
            var rf = ReadFile(fp);
            CurrentFileName = Path.GetFileName(fp);

            dynamic data = rf.data;
            string fileType = rf.fileType;

            bool isTexture = fileType is "TEX";
            bool isGIF = fileType is "GIF87" or "GIF89";
            bool isAnimated = isGIF || (isTexture && data.FrameCount > 1);

            Texture.IsTexture = isTexture;
            Texture.IsAnimated = isAnimated;
            Texture.Format = isTexture ? data.TextureFormat.ToString() : fileType;

            if (isGIF)
            {
                tsProgress.Visible = true;
                bgwExtractFrames.RunWorkerAsync(data);
            }
            else
            {
                if (isTexture)
                    CheckFlagInListbox(clbFlag, (int)data.Flags);

                if (isAnimated)
                    lbmp.AddRange(data.BitmapFrames);
                else
                    lbmp.Add(isTexture ? data.BitmapFrames[0] : data);

                var firstFrame = lbmp.First();

                Texture.Width = firstFrame.Width;
                Texture.Height = firstFrame.Height;
                Texture.PixelFormat = firstFrame.PixelFormat.ToString();

                if (Texture.IsAnimated)
                    Texture.FrameDuration = Convert.ToInt32(Texture.IsTexture ? data.Animation[0].FrameDuration * 1000 * 10 : 100);
            }

            return new { lbmp, data = rf.data, fileType };
        }

        private dynamic ReadFile(string fp)
        {
            string ext = Path.GetExtension(fp);

            int maxSignatureLength = FileSignatures.Max(x => x.Value.Length);
            byte[] signatureBytes = new byte[maxSignatureLength];

            using (var fs = File.OpenRead(fp))
                fs.Read(signatureBytes, offset: 0, maxSignatureLength);

            dynamic data = null;
            string fileType = string.Empty;

            foreach (var x in FileSignatures)
                fileType = x.Value.SequenceEqual(signatureBytes.Take(x.Value.Length)) ? x.Key : fileType;

            if (fileType is "PNG" or "BMP" || fileType is "JPG" or "JPEG" || fileType is "GIF87" or "GIF89")
                data = Image.FromFile(fp);
            else if (fileType is "TGA" or "DDS" || ext is ".tga" or ".dds")
                data = LoadTARGA(fp);
            else if (fileType is "TEX")
                data = LoadTexture(fp);

            return new { data, fileType };
        }

        private void ResetControls()
        {
            // reset data
            Texture = new CTexture();

            // reset frame id
            CurrentFrameID = 0;

            // reset controls
            lbFrameDuration.Visible = false;
            lbFrameDurationValue.Visible = false;
            trbFrameDuration.Visible = false;
            cbOnlyCurrentFrame.Visible = false;
            btnPlayPauseAnimation.Visible = false;

            btnPlayPauseAnimation.Text = "Pause";
            btnPlayPauseAnimation.Image = Resources.Pause_grey_16x;

            tslbIconPosition.Text = "0 x 0";

            trbHue.Value = 0;

            // stop animation if enabeld
            if (AnimationTimer.Enabled)
                AnimationTimer.Stop();
        }


        private Bitmap[] ExtractFiles(dynamic fp, bool sf) // sf => is single file
        {
            var lbmp = new List<Bitmap>();

            if (sf)
            {
                var r = ExtractFrameInfo(fp, lbmp);
                lbmp = r.lbmp;
            }
            else
            {
                for (int i = 0; i < fp.Length; i++)
                {
                    if (i is 0)
                    {
                        var r = ExtractFrameInfo(fp[i], lbmp);
                        lbmp = r.lbmp;

                        i++;
                    }

                    if (i != fp.Length && !Texture.IsAnimated && !Texture.IsTexture)
                        lbmp.Add(ReadFile(fp[i]).data);
                }
            }
           
            return lbmp.ToArray();
        }

        private void ReadFiles(dynamic f, bool sf = false)
        {
            ResetControls();

            var frames = ExtractFiles(f, sf);

            if (!bgwExtractFrames.IsBusy)
            {
                OriginalBitmapFrames = new Bitmap[frames.Length];
                for (int i = 0; i < frames.Length; i++)
                    OriginalBitmapFrames[i] = frames[i].Clone();

                Texture.BitmapFrames = frames;
                Texture.IsAnimated = (frames.Length > 1);

                SetupControls();
            }
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
            => SetFrame(increase: true);

        private void bgwExtractFrames_DoWork(object sender, DoWorkEventArgs e)
            => e.Result = ExtractFrames((Bitmap)e.Argument);

        private void bgwExtractFrames_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            int fc = Convert.ToInt32(e.UserState);
            int cf = e.ProgressPercentage;

            tslbStatus.Text = $"Extracting frames... {cf}/{fc}";
            tsProgress.Value = (cf * 100 / fc);
        }

        private void bgwExtractFrames_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Texture.BitmapFrames = (Bitmap[])e.Result;

            OriginalBitmapFrames = new Bitmap[Texture.FrameCount];
            for (int i = 0; i < Texture.FrameCount; i++)
                OriginalBitmapFrames[i] = (Bitmap)Texture.GetFrame(i).Clone();

            Texture.IsAnimated = Texture.FrameCount > 1;
            Texture.PixelFormat = Texture.FirstFrame.PixelFormat.ToString();
            Texture.Width = Texture.FirstFrame.Width;
            Texture.Height = Texture.FirstFrame.Height;

            tsProgress.Visible = false;
            tslbStatus.Text = $"Extracted {Texture.FrameCount} gif frames";

            SetupControls();
        }

        private Bitmap[] ExtractFrames(Bitmap bmp)
        {
            int frameCount = bmp.GetFrameCount(FrameDimension.Time);
            var BitmapFrames = new Bitmap[frameCount];

            for (int i = 0; i < frameCount; i++)
            {
                bmp.SelectActiveFrame(FrameDimension.Time, i);
                BitmapFrames[i] = new Bitmap(bmp.Size.Width, bmp.Size.Height);
                Graphics.FromImage(BitmapFrames[i]).DrawImage(bmp, new Point(0, 0));

                bgwExtractFrames.ReportProgress(i + 1, frameCount);
            }

            return BitmapFrames;
        }

        private dynamic CreateTexture()
        {
            var bt = new CBinaryTexture
            {
                Width = (uint)Texture.Width,
                FirstMipLevel = 1,
                Height = (uint)Texture.Height,
                MipMapCount = 1,
                Flags = (uint)GetFlagFromListbox(clbFlag),
                FrameCount = (uint)Texture.BitmapFrames.Length,
                BitmapFrames = Texture.BitmapFrames
            };

            if (Texture.IsAnimated)
            {
                bt.Animation = new CTextureAnimation[1];
                bt.Animation[0] = new CTextureAnimation
                {
                    FrameDuration = Texture.FrameDuration / (1000.0f * 10),
                    FrameCount = Texture.FrameCount
                };
            }

            return bt;
        }

        private void FillFrameBox(int w = 90, int h = 90)
        {
            var imageList = new ImageList();
            imageList.ImageSize = new Size(w, h);
            imageList.Images.AddRange(Texture.BitmapFrames);

            lvFrames.LargeImageList = imageList;
            for (int i = 0; i < imageList.Images.Count; i++)
                lvFrames.Items.Add(new ListViewItem { ImageIndex = i, Text = $"Frame {i}" });
        }

        private void SetupControls()
        {
            IsFileLoaded = true;

            pbTexture.Width = Texture.Width;
            pbTexture.Height = Texture.Height;
            pbTexture.Anchor = AnchorStyles.None;

            pbTexture.Location = new Point((pTexture.Width / 2) - (Texture.Width / 2),
                            (pTexture.Height / 2) - (Texture.Height / 2));

            if (lvFrames.LargeImageList != null || !Texture.IsAnimated)
                lvFrames.Clear();

            if (Texture.IsAnimated)
            {
                if (ShowFrameBox && IsFileLoaded)
                    FillFrameBox();

                if (Texture.FrameDuration is 0)
                    Texture.FrameDuration = 100;

                AnimationTimer.Interval = Texture.FrameDuration;
                AnimationTimer.Start();

                // show animation controls
                lbFrameDuration.Visible = true;
                lbFrameDurationValue.Visible = true;
                trbFrameDuration.Visible = true;
                cbOnlyCurrentFrame.Visible = true;
                lbCurrentFrame.Visible = true;
                btnPlayPauseAnimation.Visible = true;

                trbFrameDuration.Value = 100;
                lbFrameDurationValue.Text = Texture.FrameDuration + " Milliseconds";
            }
            else
                lbCurrentFrame.Text = "Not Animated " + (Texture.IsTexture ? "Texture" : "Image");

            Text = $"ChaosTools.Texture - " + (Texture.IsAnimated ? $"{Texture.FrameCount} Frames" : CurrentFileName);

            bool isIcon = false;
            foreach (var x in IconOffsets)
            {
                if(CurrentFileName.Contains(x.Key, StringComparison.OrdinalIgnoreCase))
                {
                    isIcon = true;
                    IconOffset = x.Value;
                }
            }

            tslbIconPosition.Visible = isIcon;
            IconMode = isIcon;

            btnUndo.Location = Texture.IsAnimated ? new Point(160, 217) : new Point(15, 217);
            btnUndo.Size = new Size(Texture.IsAnimated ? 88 : 233, btnUndo.Size.Height);
            pbFrameIcon.Visible = Texture.IsAnimated;

            // show first frame
            pbTexture.Image = Texture.FirstFrame;

            tslbFormat.Text = Texture.Format;
            tslbStatus.Text = $"{Texture.Width} x {Texture.Height} x {Texture.PixelFormat} ";
        }

        private void pbTexture_OnMouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta is 0 || (e.Delta < 0 && pbTexture.Width < 50) || (e.Delta > 0 && pbTexture.Width > 2000) || IconMode)
                return;

            pbTexture.Width += Convert.ToInt32(pbTexture.Width * e.Delta / (4 * 1000));
            pbTexture.Height += Convert.ToInt32(pbTexture.Height * e.Delta / (4 * 1000));
        }

        private Bitmap DrawIcon(Image img, Bitmap icon, int offset = 32)
        {
            var bmp = (Bitmap)img.Clone();

            if (IconsCreated is 0 || bmp.Width <= (offset * IconsCreated))
            {
                bmp = DrawColumn(bmp, offset);
                Texture.Height += offset;

                if (IconsCreated > 0)
                    IconsCreated = 0;
            }

            var g = Graphics.FromImage(bmp);
            g.DrawImage(icon, new Point(IconsCreated is not 0 ? offset * IconsCreated : 0, Texture.Height - offset));

            IconsCreated++;
            return bmp;
        }

        public Bitmap AppendBitmap(Bitmap source, Bitmap target, int spacing)
        {
            Bitmap bmp = new Bitmap(source.Width, source.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(source, new Rectangle(0, 0, source.Width, source.Height));
                g.DrawImage(target, new Rectangle(0, 0, source.Width, source.Height));
            }

            return bmp;
        }


        // --- menu bar
        private void tsAbout_Click(object sender, EventArgs e)
            => new frmAbout().Show();

        private void tsExit_Click(object sender, EventArgs e)
            => Application.Exit();

        private void tsShowBox_Click(object sender, EventArgs e)
        {
            var c = sender as ToolStripMenuItem;
            c.Checked = !c.Checked;
            string name = c.Name;

            if (name is "tsShowEditBox")
            {
                ShowEditBox = !ShowEditBox;
                pEditBox.Visible = ShowEditBox;
            }
            else if (name is "tsShowFrameBox")
            {
                ShowFrameBox = !ShowFrameBox;

                if (ShowFrameBox && Texture.IsAnimated && lvFrames.LargeImageList is null && IsFileLoaded)
                    FillFrameBox();

                lvFrames.Visible = ShowFrameBox;
            }
            else if (name is "tsShowFlagBox")
            {
                ShowFlagBox = !ShowFlagBox;
                pFlagBox.Visible = ShowFlagBox;
            }
        }

        private void tsImportUV_Click(object sender, EventArgs e)
        {
            if (!IsFileLoaded || Texture.IsAnimated)
                return;

            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Load Mesh File",
                Filter = "Last Chaos Mesh|*.bm|Serious Sam 1.10 Mesh|*.bm",
                RestoreDirectory = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var bmp = DrawUV(pbTexture.Width, pbTexture.Height, ofd.FileName);
                pbTexture.Image = AppendBitmap((Bitmap)pbTexture.Image, bmp, 0);
            }
        }

        private void tsOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Title = "Load Image",
                Filter = "All Formats|*.tex;*.png;*.jpg;*.jpeg;*.bmp;*.gif;*.tga;*.dds|Last Chaos Texture|*.tex|Portable Network Graphics|*.png|Joint Photographic Experts Group|*.jpg;*.jpeg|Windows Bitmap Image|*.bmp|Graphics Interchange Format|*.gif|TrueVision TGA|*.tga|DirectDraw Surface|*.dds",
                RestoreDirectory = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
                ReadFiles(ofd.FileName, sf: true);
        }



        private void tsSaveTexture_Click(object sender, EventArgs e)
        {
            if (!IsFileLoaded)
                return;

            SaveFileDialog sfd = new SaveFileDialog
            {
                Title = "Save Texture",
                Filter = "Last Chaos Texture (Uncompressed)|*.tex",
                DefaultExt = "tex",
                AddExtension = true,
                RestoreDirectory = true
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                // perform pixel and size check
                var equalityCheck = Texture.BitmapFrames.ToList().Where(x => x.Width != Texture.FirstFrame.Width 
                        || x.Height != Texture.FirstFrame.Height || x.PixelFormat != Texture.FirstFrame.PixelFormat).Count();

                if (equalityCheck is 0)
                    ExportTexture(CreateTexture(), sfd.FileName);
                else
                    tslbStatus.Text = $"ERROR: Texture cannot be exported as the frames are different";
            }
        }

        private void tsSaveAs_Click(object sender, EventArgs e)
        {
            if (!IsFileLoaded)
                return;

            SaveFileDialog sfd = new SaveFileDialog
            {
                Title = "Save Image",
                Filter = " Last Chaos Texture (Uncompressed)|*.tex|Portable Network Graphics|*.png|Joint Photographic Experts Group|*.jpg;*.jpeg|Windows Bitmap Image|*.bmp",
                DefaultExt = "tex",
                AddExtension = true,
                RestoreDirectory = true
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                var ext = Path.GetExtension(sfd.FileName);

                if (ext is ".tex")
                    ExportTexture(CreateTexture(), sfd.FileName);
                else
                    ExportFrames(Texture.BitmapFrames, sfd.FileName, ext);

            }
        }

        // drag controls
        private void MovableControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                CursorX = e.X;
                CursorY = e.Y;
            }
        }

        private void MovableControl_MouseMove(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (c != null && e.Button == MouseButtons.Left)
            {
                if (c.Name is "pbTexture" && !IsFileLoaded)
                    return;

                c.Left = e.X + c.Left - CursorX;
                c.Top = e.Y + c.Top - CursorY;
            }

            if (IconMode && c.Name is "pbTexture")
            {
                IconX = (int)Math.Floor(e.X / (float)IconOffset);
                IconY = (int)Math.Floor(e.Y / (float)IconOffset);

                tslbIconPosition.Text = $"{IconX} x {IconY}";
            }
        }


        private void pbTexture_MouseClick(object sender, MouseEventArgs e)
        {
            Control c = sender as Control;
            if (c.Name is "pbTexture" && e.Button == MouseButtons.Right)
            {
                var bmp = new Bitmap(pbTexture.Image);

                int x = bmp.Width * e.X / pbTexture.Width;
                int y = bmp.Height * e.Y / pbTexture.Height;

                SelectedColor = bmp.GetPixel(x, y);

                DrawSelectedColor();
            }
        }

        private void trbFrameDuration_Scroll(object sender, EventArgs e)
        {
            Texture.FrameDuration = trbFrameDuration.Value;
            AnimationTimer.Interval = Texture.FrameDuration;

            lbFrameDurationValue.Text = Texture.FrameDuration + " Milliseconds";
        }

        private void btnChangeToTransparent_MouseClick(object sender, MouseEventArgs e)
        {
            if (!IsFileLoaded || e.Button is not MouseButtons.Left)
                return;

            if (!cbOnlyCurrentFrame.Checked)
                for (int i = 0; i < Texture.FrameCount; i++)
                    Texture.GetFrame(i).MakeTransparent(SelectedColor);
            else
                CurrentFrame.MakeTransparent(SelectedColor);

            pbTexture.Refresh();
        }

        private void trbHue_Scroll(object sender, EventArgs e)
        {
            if (!IsFileLoaded)
                return;

            if (cbOnlyCurrentFrame.Checked)
                Texture.SetFrame(CurrentFrameID, RotateHue(CurrentFrame, trbHue.Value));
            else
                for (int i = 0; i < Texture.FrameCount; i++)
                    Texture.SetFrame(i, RotateHue(Texture.GetFrame(i), trbHue.Value));

            if (cbOnlyCurrentFrame.Checked || !AnimationTimer.Enabled)
            {
                pbTexture.Image = Texture.GetFrame(Texture.IsAnimated ? CurrentFrameID : 0);
                pbTexture.Refresh();
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            if (!IsFileLoaded)
                return;

            if (Texture.IsAnimated && cbOnlyCurrentFrame.Checked)
                Texture.SetFrame(CurrentFrameID, (Bitmap)OriginalBitmapFrames[CurrentFrameID].Clone());
            else
                for (int i = 0; i < Texture.FrameCount; i++)
                    Texture.SetFrame(i, (Bitmap)OriginalBitmapFrames[i].Clone());

            trbHue.Value = 0;

            pbTexture.Image = CurrentFrame;
            pbTexture.Refresh();
        }

        private void btnPlayPauseAnimation_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button is MouseButtons.Left)
                ChangeAnimationState();
        }

        private void ChangeAnimationState()
        {
            if (!IsFileLoaded || !Texture.IsAnimated)
                return;

            bool isTimerRunning = AnimationTimer.Enabled;

            if (isTimerRunning) AnimationTimer.Stop();
            else AnimationTimer.Start();

            btnPlayPauseAnimation.Text = isTimerRunning ? "Play" : "Pause";
            btnPlayPauseAnimation.Image = isTimerRunning ? Resources.Run_grey_16x : Resources.Pause_grey_16x;
        }

        public static void SetDoubleBuffered(Control c)
        {
            PropertyInfo pi = typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance);
            pi.SetValue(c, true, null);
        }

        // bitmap operation
        private Bitmap RotateHue(Bitmap bmp, int value)
        {
            var rad = Math.PI * value / 180.0;
            var cos = (float)Math.Cos(rad);
            var sin = (float)Math.Sin(rad);

            var colorMatrix = new ColorMatrix(new[]
            {
                new[]
                {
                    0.213f + cos * 0.787f - sin * 0.213f,
                    0.213f - cos * 0.213f + sin * 0.143f,
                    0.213f - cos * 0.213f - sin * 0.787f,
                    0f, 0f
                },
                new[]
                {
                    0.715f - cos * 0.715f - sin * 0.715f,
                    0.715f + cos * 0.285f + sin * 0.140f,
                    0.715f - cos * 0.715f + sin * 0.715f,
                    0f, 0f
                },
                new[]
                {
                    0.072f - cos * 0.072f + sin * 0.928f,
                    0.072f - cos * 0.072f - sin * 0.283f,
                    0.072f + cos * 0.928f + sin * 0.072f,
                    0f, 0f
                },
                new[] { 0f, 0f, 0f, 1f, 0f },
                new[] { 0f, 0f, 0f, 0f, 1f }
             });

            var imageAttributes = new ImageAttributes();
            imageAttributes.SetColorMatrix(colorMatrix);

            var width = bmp.Width;
            var height = bmp.Height;

            var graphics = Graphics.FromImage(bmp);
            graphics.DrawImage(bmp, new Rectangle(0, 0, width, height),
                0, 0, width, height, GraphicsUnit.Pixel, imageAttributes);

            return bmp;
        }

        public static Bitmap ChangeColor(Bitmap bmp, Color o, Color n)
        {
            var attributes = new ImageAttributes();
            attributes.SetRemapTable(new ColorMap[]
            {
                new ColorMap()
                {
                    OldColor = o,
                    NewColor = n,
                }

            }, ColorAdjustType.Bitmap);

            using (Graphics g = Graphics.FromImage(bmp))
                g.DrawImage(bmp, new Rectangle(Point.Empty, bmp.Size), 0, 0, bmp.Width, bmp.Height, GraphicsUnit.Pixel, attributes);

            return bmp;
        }

        private Bitmap DrawUV(int w, int h, string fp)
        {
            var model = LoadMesh(fp);

            var bmp = new Bitmap(w, h);
            var g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.CompositingQuality = CompositingQuality.GammaCorrected;

            for (int i = 0; i < model.UVMaps[0].UV.Length; i++)
            {
                float u = model.UVMaps[0].UV[i].U * pbTexture.Width;
                float v = model.UVMaps[0].UV[i].V * pbTexture.Height;

                g.FillEllipse(new SolidBrush(SelectedColor), new RectangleF(u, v, 3, 3));
            }

            return bmp;
        }

        private Bitmap DrawColumn(Image img, int offset = 32)
        {
            var bmp = new Bitmap(img.Width, img.Height + offset);
            var g = Graphics.FromImage(bmp);
            g.DrawImage(img, 0, 0, img.Width, img.Height);

            return bmp;
        }

        private Bitmap DrawGrid(Image bmp, int offset = 32)
        {
            var pen = new Pen(Color.Red);
            var g = Graphics.FromImage(bmp);
            g.SmoothingMode = SmoothingMode.AntiAlias;

            for (int i = 0; i < bmp.Width; i += offset)
                g.DrawLine(pen, new Point(0, i), new Point(bmp.Height, i));

            for (int i = 0; i < bmp.Height; i += offset)
                g.DrawLine(pen, new Point(i, 0), new Point(i, bmp.Width));

            // g.DrawImage(Resources.red, bmp.Width, bmp.Height - offset);

            return (Bitmap)bmp;
        }

        private void DrawSelectedColor(int size = 14)
        {
            var ctl = btnChangeToTransparent;
            var bmp = new Bitmap(ctl.Width, ctl.Height);

            using (var g = Graphics.FromImage(bmp))
            {
                g.SmoothingMode = SmoothingMode.AntiAlias;
                g.CompositingQuality = CompositingQuality.GammaCorrected;

                g.FillEllipse(new SolidBrush(SelectedColor), new Rectangle(5, 4, size, size));
            }

            ctl.Image = bmp;
        }

        public static Bitmap CreateBitmap(int w, int h, byte[] pd, PixelFormat pf)
        {
            Bitmap bmp = new Bitmap(w, h, pf);
            BitmapData data = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.WriteOnly, bmp.PixelFormat);
            Marshal.Copy(pd, byte.MinValue, data.Scan0, pd.Length);
            bmp.UnlockBits(data);

            return bmp;
        }

        private static Bitmap CreateTransparentBackground(int size = 10)
        {
            var bmp = new Bitmap(size * 2, size * 2);

            using (SolidBrush sb = new SolidBrush(Color.LightGray))
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.FillRectangle(sb, 0, 0, size, size);
                g.FillRectangle(sb, size, size, size, size);
            }

            return bmp;
        }

        // flag operation
        private void CheckFlagInListbox(CheckedListBox clb, int flag)
        {
            for (int i = 0; i < clb.Items.Count; ++i)
                clb.SetItemChecked(i, Convert.ToBoolean((1 << i) & flag));
        }

        private int GetFlagFromListbox(CheckedListBox clb)
        {
            int flag = 0;
            for (int i = 0; i < clb.Items.Count; i++)
                if (clb.GetItemChecked(i))
                    flag += (1 << i);

            return flag;
        }

        // frame wrappers
        private Bitmap CurrentFrame
            => Texture.GetFrame(CurrentFrameID);

        private void SetFrame(bool increase)
        {
            if (!IsFileLoaded || !Texture.IsAnimated)
                return;

            CurrentFrameID = increase ? (CurrentFrameID < Texture.FrameCount - 1) ? CurrentFrameID + 1 : 0 
                : (CurrentFrameID > 0) ? CurrentFrameID - 1 : Texture.FrameCount - 1;

            lbCurrentFrame.Text = $"Frame {CurrentFrameID}";
            pbTexture.Image = CurrentFrame;
            pbTexture.Refresh();
        }

        private void SetFrameDuration(bool increase)
        {
            if (!IsFileLoaded || !Texture.IsAnimated)
                return;

            Texture.FrameDuration = increase ? (Texture.FrameDuration != trbFrameDuration.Maximum) ? Texture.FrameDuration + 10 : 10 
                : (Texture.FrameDuration >= 11) ? Texture.FrameDuration - 10 : trbFrameDuration.Maximum;

            AnimationTimer.Interval = Texture.FrameDuration;
            trbFrameDuration.Value = Texture.FrameDuration;
            lbFrameDurationValue.Text = Texture.FrameDuration + " Milliseconds";
        }

        // export/import wrappers
        private static void ExportFrames(Bitmap[] lbmp, string fp, string ext)
        {
            for (int i = 0; i < lbmp.Length; i++)
            {
                var imgf = ext switch
                {
                    ".jpg" => ImageFormat.Jpeg,
                    ".jpeg" => ImageFormat.Jpeg,
                    ".bmp" => ImageFormat.Bmp,
                    ".png" => ImageFormat.Png
                };

                lbmp[i].Save(fp.Substring(0, fp.Length - ext.Length) + (lbmp.Length > 1 ? i : string.Empty) + ext, imgf);
            }
        }

        private Bitmap LoadTARGA(string fp)
        {
            var img = Pfim.Pfim.FromFile(fp);

            PixelFormat pf = img.Format switch
            {
                Pfim.ImageFormat.Rgb24 => PixelFormat.Format24bppRgb,
                Pfim.ImageFormat.Rgba32 => PixelFormat.Format32bppArgb,
                Pfim.ImageFormat.R5g5b5 => PixelFormat.Format16bppRgb555,
                Pfim.ImageFormat.R5g6b5 => PixelFormat.Format16bppRgb565,
                Pfim.ImageFormat.R5g5b5a1 => PixelFormat.Format16bppArgb1555,
                Pfim.ImageFormat.Rgb8 => PixelFormat.Format8bppIndexed
            };

            return CreateBitmap(img.Width, img.Height, img.Data, pf);
        }

        private static void ExportTexture(CBinaryTexture bt, string fp)
            => new ChaosAsset().Export(AssetType.Texture, bt, fp, AssetDataType.Binary);

        private dynamic LoadTexture(string fp)
            => new ChaosAsset().Import(AssetType.Texture, fp, AssetDataType.Binary);

        private dynamic LoadMesh(string fp)
            => new ChaosAsset().Import(AssetType.Mesh, fp, AssetDataType.Binary).Mesh[0];
    }
}

using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace ChaosTools.Texture
{
    public partial class frmExportUV : Form
    {
        private Color SurfaceColor = Color.White;
        private Color WireframeColor = Color.Black;
        private Bitmap SelectedImage = null;

        public frmExportUV()
        {
            InitializeComponent();
            rbOptions_CheckedChanged(rbWireframe, null);
        }

        private void pbSurfaceColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                SurfaceColor = cd.Color;
                pbSurfaceColor.BackColor = cd.Color;
                rbWireframe.Checked = true;
            }
        }

        private void pbWireframeColor_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                WireframeColor = cd.Color;
                pbWireframeColor.BackColor = cd.Color;
                rbWireframe.Checked = true;
            }
        }

        private void rbOptions_CheckedChanged(object sender, EventArgs e)
        {
            var t = frmMain.Texture;
            var m = frmMain.Mesh;

            if (rbWireframe.Checked)
                pbPreview.Image = DrawUV(t.Width, t.Height, m, WireframeColor, wireframe: true);
            else if (rbSurfaces.Checked)
                pbPreview.Image = DrawUV(t.Width, t.Height, m, SurfaceColor, wireframe: false);
            else if (rbWireframeTexture.Checked)
            {
                var bmp = DrawUV(t.Width, t.Height, m, WireframeColor, wireframe: true);
                pbPreview.Image = AppendBitmap((Bitmap)t.BitmapFrames[0].Clone(), bmp);
            }
            else if(rbWireframeSurfaces.Checked)
            {
                var bmpSurfaces = DrawUV(t.Width, t.Height, m, SurfaceColor, wireframe: false);
                var bmpWireframe = DrawUV(t.Width, t.Height, m, WireframeColor, wireframe: true);
                pbPreview.Image = AppendBitmap(bmpSurfaces, bmpWireframe);
            }

            SelectedImage = (Bitmap)pbPreview.Image;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Title = "Save Image",
                Filter = "Portable Network Graphics|*.png",
                DefaultExt = "png",
                AddExtension = true,
                RestoreDirectory = true
            };

            if (sfd.ShowDialog() == DialogResult.OK && SelectedImage != null)
                SelectedImage.Save(sfd.FileName); // new Bitmap((Bitmap)pbPreview.Image)
        }
        
        private Bitmap AppendBitmap(Bitmap s, Bitmap t)
        {
            Bitmap bmp = new Bitmap(s.Width, s.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(s, new Rectangle(0, 0, s.Width, s.Height));
                g.DrawImage(t, new Rectangle(0, 0, s.Width, s.Height));
            }

            return bmp;
        }

        private Bitmap DrawUV(int w, int h, dynamic bm, Color c, bool wireframe = true)
        {
            var bmp = new Bitmap(w, h, PixelFormat.Format32bppArgb);
            var g = Graphics.FromImage(bmp);

            g.SmoothingMode = SmoothingMode.AntiAlias;
            // g.CompositingQuality = CompositingQuality.GammaCorrected;
            // g.TranslateTransform(0.0F, -(float)h); ~ if uv is from wavefront obj

            if (!wireframe)
                g.Clear(Color.Black);

            for (int i = 0; i < bm.SurfaceCount; i++)
            {
                for (int j = 0; j < bm.Surfaces[i].TriangleCount; j++)
                {
                    int fw = (int)bm.Surfaces[i].FirstVertex;

                    int v0 = bm.Surfaces[i].Triangles[j].v0 + fw;
                    int v1 = bm.Surfaces[i].Triangles[j].v1 + fw;
                    int v2 = bm.Surfaces[i].Triangles[j].v2 + fw;

                    var v0pf = new PointF(bm.UVMaps[0].UV[v0].U * w, bm.UVMaps[0].UV[v0].V * h);
                    var v1pf = new PointF(bm.UVMaps[0].UV[v1].U * w, bm.UVMaps[0].UV[v1].V * h);
                    var v2pf = new PointF(bm.UVMaps[0].UV[v2].U * w, bm.UVMaps[0].UV[v2].V * h);

                    if (wireframe) g.DrawPolygon(new Pen(c), new PointF[] { v0pf, v1pf, v2pf });
                    else g.FillPolygon(new SolidBrush(c), new PointF[] { v0pf, v1pf, v2pf });
                }
            }

            return bmp;
        }

    }
}

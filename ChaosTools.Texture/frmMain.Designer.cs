
namespace ChaosTools.Texture
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.stripStatus = new System.Windows.Forms.StatusStrip();
            this.tslbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tslbIconPosition = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslbFormat = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripMenu = new System.Windows.Forms.MenuStrip();
            this.tsFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsSaveTexture = new System.Windows.Forms.ToolStripMenuItem();
            this.tsSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsView = new System.Windows.Forms.ToolStripMenuItem();
            this.tsShowEditBox = new System.Windows.Forms.ToolStripMenuItem();
            this.tsShowFrameBox = new System.Windows.Forms.ToolStripMenuItem();
            this.tsShowFlagBox = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAdditional = new System.Windows.Forms.ToolStripMenuItem();
            this.tsImportUV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsExportUV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pbTexture = new System.Windows.Forms.PictureBox();
            this.pTexture = new System.Windows.Forms.Panel();
            this.pFlagBox = new System.Windows.Forms.Panel();
            this.clbFlag = new System.Windows.Forms.CheckedListBox();
            this.lvFrames = new System.Windows.Forms.ListView();
            this.pEditBox = new System.Windows.Forms.Panel();
            this.pbFrameIcon = new System.Windows.Forms.PictureBox();
            this.btnPlayPauseAnimation = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbCurrentFrame = new System.Windows.Forms.Label();
            this.cbOnlyCurrentFrame = new System.Windows.Forms.CheckBox();
            this.lbFrameDurationValue = new System.Windows.Forms.Label();
            this.lbFrameDuration = new System.Windows.Forms.Label();
            this.trbFrameDuration = new System.Windows.Forms.TrackBar();
            this.btnChangeToTransparent = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.trbHue = new System.Windows.Forms.TrackBar();
            this.bgwExtractFrames = new System.ComponentModel.BackgroundWorker();
            this.stripStatus.SuspendLayout();
            this.stripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTexture)).BeginInit();
            this.pTexture.SuspendLayout();
            this.pFlagBox.SuspendLayout();
            this.pEditBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrameIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFrameDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbHue)).BeginInit();
            this.SuspendLayout();
            // 
            // stripStatus
            // 
            this.stripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbStatus,
            this.tsProgress,
            this.tslbIconPosition,
            this.tslbFormat});
            this.stripStatus.Location = new System.Drawing.Point(0, 672);
            this.stripStatus.Name = "stripStatus";
            this.stripStatus.Size = new System.Drawing.Size(1065, 22);
            this.stripStatus.TabIndex = 0;
            this.stripStatus.Text = "statusStrip1";
            // 
            // tslbStatus
            // 
            this.tslbStatus.Name = "tslbStatus";
            this.tslbStatus.Size = new System.Drawing.Size(26, 17);
            this.tslbStatus.Text = "Idle";
            // 
            // tsProgress
            // 
            this.tsProgress.Name = "tsProgress";
            this.tsProgress.Size = new System.Drawing.Size(100, 18);
            this.tsProgress.Visible = false;
            // 
            // tslbIconPosition
            // 
            this.tslbIconPosition.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Left;
            this.tslbIconPosition.Name = "tslbIconPosition";
            this.tslbIconPosition.Size = new System.Drawing.Size(35, 19);
            this.tslbIconPosition.Text = "0 x 0";
            this.tslbIconPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tslbIconPosition.Visible = false;
            // 
            // tslbFormat
            // 
            this.tslbFormat.Name = "tslbFormat";
            this.tslbFormat.Size = new System.Drawing.Size(1024, 17);
            this.tslbFormat.Spring = true;
            this.tslbFormat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stripMenu
            // 
            this.stripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsFile,
            this.tsView,
            this.tsAdditional,
            this.tsAbout});
            this.stripMenu.Location = new System.Drawing.Point(0, 0);
            this.stripMenu.Name = "stripMenu";
            this.stripMenu.Size = new System.Drawing.Size(1065, 24);
            this.stripMenu.TabIndex = 1;
            this.stripMenu.Text = "menuStrip1";
            // 
            // tsFile
            // 
            this.tsFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsOpen,
            this.toolStripSeparator,
            this.tsSaveTexture,
            this.tsSaveAs,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.tsFile.Name = "tsFile";
            this.tsFile.Size = new System.Drawing.Size(37, 20);
            this.tsFile.Text = "&File";
            // 
            // tsOpen
            // 
            this.tsOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsOpen.Image")));
            this.tsOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOpen.Name = "tsOpen";
            this.tsOpen.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.tsOpen.Size = new System.Drawing.Size(146, 22);
            this.tsOpen.Text = "&Open";
            this.tsOpen.Click += new System.EventHandler(this.tsOpen_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(143, 6);
            // 
            // tsSaveTexture
            // 
            this.tsSaveTexture.Image = ((System.Drawing.Image)(resources.GetObject("tsSaveTexture.Image")));
            this.tsSaveTexture.Name = "tsSaveTexture";
            this.tsSaveTexture.Size = new System.Drawing.Size(146, 22);
            this.tsSaveTexture.Text = "Save Texture";
            this.tsSaveTexture.Click += new System.EventHandler(this.tsSaveTexture_Click);
            // 
            // tsSaveAs
            // 
            this.tsSaveAs.Image = ((System.Drawing.Image)(resources.GetObject("tsSaveAs.Image")));
            this.tsSaveAs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSaveAs.Name = "tsSaveAs";
            this.tsSaveAs.Size = new System.Drawing.Size(146, 22);
            this.tsSaveAs.Text = "&Save As";
            this.tsSaveAs.Click += new System.EventHandler(this.tsSaveAs_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.tsExit_Click);
            // 
            // tsView
            // 
            this.tsView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsShowEditBox,
            this.tsShowFrameBox,
            this.tsShowFlagBox});
            this.tsView.Name = "tsView";
            this.tsView.Size = new System.Drawing.Size(44, 20);
            this.tsView.Text = "&View";
            // 
            // tsShowEditBox
            // 
            this.tsShowEditBox.Checked = true;
            this.tsShowEditBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsShowEditBox.Image = ((System.Drawing.Image)(resources.GetObject("tsShowEditBox.Image")));
            this.tsShowEditBox.Name = "tsShowEditBox";
            this.tsShowEditBox.Size = new System.Drawing.Size(130, 22);
            this.tsShowEditBox.Text = "Edit Box";
            this.tsShowEditBox.Click += new System.EventHandler(this.tsShowBox_Click);
            // 
            // tsShowFrameBox
            // 
            this.tsShowFrameBox.Image = ((System.Drawing.Image)(resources.GetObject("tsShowFrameBox.Image")));
            this.tsShowFrameBox.Name = "tsShowFrameBox";
            this.tsShowFrameBox.Size = new System.Drawing.Size(130, 22);
            this.tsShowFrameBox.Text = "Frame Box";
            this.tsShowFrameBox.Click += new System.EventHandler(this.tsShowBox_Click);
            // 
            // tsShowFlagBox
            // 
            this.tsShowFlagBox.Image = ((System.Drawing.Image)(resources.GetObject("tsShowFlagBox.Image")));
            this.tsShowFlagBox.Name = "tsShowFlagBox";
            this.tsShowFlagBox.Size = new System.Drawing.Size(130, 22);
            this.tsShowFlagBox.Text = "Flag Box";
            this.tsShowFlagBox.Click += new System.EventHandler(this.tsShowBox_Click);
            // 
            // tsAdditional
            // 
            this.tsAdditional.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsImportUV,
            this.tsExportUV});
            this.tsAdditional.Name = "tsAdditional";
            this.tsAdditional.Size = new System.Drawing.Size(74, 20);
            this.tsAdditional.Text = "&Additional";
            // 
            // tsImportUV
            // 
            this.tsImportUV.Name = "tsImportUV";
            this.tsImportUV.Size = new System.Drawing.Size(128, 22);
            this.tsImportUV.Text = "Import UV";
            this.tsImportUV.Click += new System.EventHandler(this.tsImportUV_Click);
            // 
            // tsExportUV
            // 
            this.tsExportUV.Name = "tsExportUV";
            this.tsExportUV.Size = new System.Drawing.Size(128, 22);
            this.tsExportUV.Text = "Export UV";
            this.tsExportUV.Click += new System.EventHandler(this.tsExportUV_Click);
            // 
            // tsAbout
            // 
            this.tsAbout.Name = "tsAbout";
            this.tsAbout.Size = new System.Drawing.Size(52, 20);
            this.tsAbout.Text = "&About";
            this.tsAbout.Click += new System.EventHandler(this.tsAbout_Click);
            // 
            // pbTexture
            // 
            this.pbTexture.BackColor = System.Drawing.Color.Transparent;
            this.pbTexture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbTexture.Image = ((System.Drawing.Image)(resources.GetObject("pbTexture.Image")));
            this.pbTexture.Location = new System.Drawing.Point(282, 29);
            this.pbTexture.Name = "pbTexture";
            this.pbTexture.Size = new System.Drawing.Size(101, 100);
            this.pbTexture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTexture.TabIndex = 2;
            this.pbTexture.TabStop = false;
            this.pbTexture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbTexture_MouseClick);
            this.pbTexture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovableControl_MouseDown);
            this.pbTexture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovableControl_MouseMove);
            this.pbTexture.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pbTexture_OnMouseWheel);
            // 
            // pTexture
            // 
            this.pTexture.Controls.Add(this.pFlagBox);
            this.pTexture.Controls.Add(this.lvFrames);
            this.pTexture.Controls.Add(this.pEditBox);
            this.pTexture.Controls.Add(this.pbTexture);
            this.pTexture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pTexture.Location = new System.Drawing.Point(0, 24);
            this.pTexture.Name = "pTexture";
            this.pTexture.Size = new System.Drawing.Size(1065, 648);
            this.pTexture.TabIndex = 3;
            // 
            // pFlagBox
            // 
            this.pFlagBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pFlagBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pFlagBox.Controls.Add(this.clbFlag);
            this.pFlagBox.Location = new System.Drawing.Point(12, 29);
            this.pFlagBox.Name = "pFlagBox";
            this.pFlagBox.Size = new System.Drawing.Size(264, 351);
            this.pFlagBox.TabIndex = 13;
            this.pFlagBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovableControl_MouseDown);
            this.pFlagBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovableControl_MouseMove);
            // 
            // clbFlag
            // 
            this.clbFlag.BackColor = System.Drawing.SystemColors.Control;
            this.clbFlag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.clbFlag.FormattingEnabled = true;
            this.clbFlag.Location = new System.Drawing.Point(8, 10);
            this.clbFlag.Name = "clbFlag";
            this.clbFlag.Size = new System.Drawing.Size(159, 324);
            this.clbFlag.TabIndex = 0;
            // 
            // lvFrames
            // 
            this.lvFrames.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lvFrames.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvFrames.BackColor = System.Drawing.SystemColors.Control;
            this.lvFrames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvFrames.FullRowSelect = true;
            this.lvFrames.HideSelection = false;
            this.lvFrames.Location = new System.Drawing.Point(861, 15);
            this.lvFrames.MultiSelect = false;
            this.lvFrames.Name = "lvFrames";
            this.lvFrames.Size = new System.Drawing.Size(192, 617);
            this.lvFrames.TabIndex = 12;
            this.lvFrames.TileSize = new System.Drawing.Size(90, 90);
            this.lvFrames.UseCompatibleStateImageBehavior = false;
            this.lvFrames.Visible = false;
            this.lvFrames.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovableControl_MouseDown);
            this.lvFrames.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovableControl_MouseMove);
            // 
            // pEditBox
            // 
            this.pEditBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pEditBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pEditBox.Controls.Add(this.pbFrameIcon);
            this.pEditBox.Controls.Add(this.btnPlayPauseAnimation);
            this.pEditBox.Controls.Add(this.btnUndo);
            this.pEditBox.Controls.Add(this.panel2);
            this.pEditBox.Controls.Add(this.panel1);
            this.pEditBox.Controls.Add(this.lbCurrentFrame);
            this.pEditBox.Controls.Add(this.cbOnlyCurrentFrame);
            this.pEditBox.Controls.Add(this.lbFrameDurationValue);
            this.pEditBox.Controls.Add(this.lbFrameDuration);
            this.pEditBox.Controls.Add(this.trbFrameDuration);
            this.pEditBox.Controls.Add(this.btnChangeToTransparent);
            this.pEditBox.Controls.Add(this.label3);
            this.pEditBox.Controls.Add(this.trbHue);
            this.pEditBox.Location = new System.Drawing.Point(12, 386);
            this.pEditBox.Name = "pEditBox";
            this.pEditBox.Size = new System.Drawing.Size(264, 250);
            this.pEditBox.TabIndex = 11;
            this.pEditBox.Visible = false;
            this.pEditBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovableControl_MouseDown);
            this.pEditBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovableControl_MouseMove);
            // 
            // pbFrameIcon
            // 
            this.pbFrameIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbFrameIcon.Image")));
            this.pbFrameIcon.Location = new System.Drawing.Point(7, 5);
            this.pbFrameIcon.Name = "pbFrameIcon";
            this.pbFrameIcon.Size = new System.Drawing.Size(16, 16);
            this.pbFrameIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbFrameIcon.TabIndex = 14;
            this.pbFrameIcon.TabStop = false;
            this.pbFrameIcon.Visible = false;
            // 
            // btnPlayPauseAnimation
            // 
            this.btnPlayPauseAnimation.Image = ((System.Drawing.Image)(resources.GetObject("btnPlayPauseAnimation.Image")));
            this.btnPlayPauseAnimation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayPauseAnimation.Location = new System.Drawing.Point(15, 217);
            this.btnPlayPauseAnimation.Name = "btnPlayPauseAnimation";
            this.btnPlayPauseAnimation.Size = new System.Drawing.Size(88, 23);
            this.btnPlayPauseAnimation.TabIndex = 17;
            this.btnPlayPauseAnimation.Text = "Pause";
            this.btnPlayPauseAnimation.UseVisualStyleBackColor = true;
            this.btnPlayPauseAnimation.Visible = false;
            this.btnPlayPauseAnimation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnPlayPauseAnimation_MouseClick);
            // 
            // btnUndo
            // 
            this.btnUndo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUndo.Location = new System.Drawing.Point(15, 217);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(233, 23);
            this.btnUndo.TabIndex = 11;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(-1, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(264, 1);
            this.panel2.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(0, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 1);
            this.panel1.TabIndex = 14;
            // 
            // lbCurrentFrame
            // 
            this.lbCurrentFrame.BackColor = System.Drawing.Color.Transparent;
            this.lbCurrentFrame.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbCurrentFrame.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCurrentFrame.Location = new System.Drawing.Point(0, 0);
            this.lbCurrentFrame.Name = "lbCurrentFrame";
            this.lbCurrentFrame.Size = new System.Drawing.Size(262, 26);
            this.lbCurrentFrame.TabIndex = 18;
            this.lbCurrentFrame.Text = "-";
            this.lbCurrentFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbOnlyCurrentFrame
            // 
            this.cbOnlyCurrentFrame.AutoSize = true;
            this.cbOnlyCurrentFrame.Location = new System.Drawing.Point(49, 40);
            this.cbOnlyCurrentFrame.Name = "cbOnlyCurrentFrame";
            this.cbOnlyCurrentFrame.Size = new System.Drawing.Size(165, 19);
            this.cbOnlyCurrentFrame.TabIndex = 16;
            this.cbOnlyCurrentFrame.Text = "Modify only current frame";
            this.cbOnlyCurrentFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbOnlyCurrentFrame.UseVisualStyleBackColor = true;
            this.cbOnlyCurrentFrame.Visible = false;
            // 
            // lbFrameDurationValue
            // 
            this.lbFrameDurationValue.BackColor = System.Drawing.Color.Transparent;
            this.lbFrameDurationValue.Location = new System.Drawing.Point(122, 75);
            this.lbFrameDurationValue.Name = "lbFrameDurationValue";
            this.lbFrameDurationValue.Size = new System.Drawing.Size(120, 15);
            this.lbFrameDurationValue.TabIndex = 13;
            this.lbFrameDurationValue.Text = "100 Milliseconds";
            this.lbFrameDurationValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbFrameDurationValue.Visible = false;
            // 
            // lbFrameDuration
            // 
            this.lbFrameDuration.AutoSize = true;
            this.lbFrameDuration.BackColor = System.Drawing.Color.Transparent;
            this.lbFrameDuration.Location = new System.Drawing.Point(17, 75);
            this.lbFrameDuration.Name = "lbFrameDuration";
            this.lbFrameDuration.Size = new System.Drawing.Size(89, 15);
            this.lbFrameDuration.TabIndex = 12;
            this.lbFrameDuration.Text = "Frame Duration";
            this.lbFrameDuration.Visible = false;
            // 
            // trbFrameDuration
            // 
            this.trbFrameDuration.AutoSize = false;
            this.trbFrameDuration.BackColor = System.Drawing.SystemColors.Control;
            this.trbFrameDuration.LargeChange = 10;
            this.trbFrameDuration.Location = new System.Drawing.Point(10, 93);
            this.trbFrameDuration.Maximum = 5000;
            this.trbFrameDuration.Minimum = 10;
            this.trbFrameDuration.Name = "trbFrameDuration";
            this.trbFrameDuration.Size = new System.Drawing.Size(238, 18);
            this.trbFrameDuration.TabIndex = 6;
            this.trbFrameDuration.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbFrameDuration.Value = 100;
            this.trbFrameDuration.Visible = false;
            this.trbFrameDuration.Scroll += new System.EventHandler(this.trbFrameDuration_Scroll);
            // 
            // btnChangeToTransparent
            // 
            this.btnChangeToTransparent.Location = new System.Drawing.Point(15, 173);
            this.btnChangeToTransparent.Name = "btnChangeToTransparent";
            this.btnChangeToTransparent.Size = new System.Drawing.Size(233, 23);
            this.btnChangeToTransparent.TabIndex = 14;
            this.btnChangeToTransparent.Text = "Change color to transparent";
            this.btnChangeToTransparent.UseVisualStyleBackColor = true;
            this.btnChangeToTransparent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnChangeToTransparent_MouseClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(15, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hue";
            // 
            // trbHue
            // 
            this.trbHue.AutoSize = false;
            this.trbHue.BackColor = System.Drawing.SystemColors.Control;
            this.trbHue.Location = new System.Drawing.Point(10, 149);
            this.trbHue.Maximum = 360;
            this.trbHue.Name = "trbHue";
            this.trbHue.Size = new System.Drawing.Size(245, 18);
            this.trbHue.TabIndex = 9;
            this.trbHue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbHue.Scroll += new System.EventHandler(this.trbHue_Scroll);
            // 
            // bgwExtractFrames
            // 
            this.bgwExtractFrames.WorkerReportsProgress = true;
            // 
            // frmMain
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 694);
            this.Controls.Add(this.pTexture);
            this.Controls.Add(this.stripStatus);
            this.Controls.Add(this.stripMenu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.stripMenu;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChaosTools.Texture";
            this.MouseWheel += new System.Windows.Forms.MouseEventHandler(this.pbTexture_OnMouseWheel);
            this.stripStatus.ResumeLayout(false);
            this.stripStatus.PerformLayout();
            this.stripMenu.ResumeLayout(false);
            this.stripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTexture)).EndInit();
            this.pTexture.ResumeLayout(false);
            this.pFlagBox.ResumeLayout(false);
            this.pEditBox.ResumeLayout(false);
            this.pEditBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbFrameIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbFrameDuration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbHue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip stripStatus;
        private System.Windows.Forms.ToolStripStatusLabel tslbStatus;
        private System.Windows.Forms.ToolStripStatusLabel tslbFormat;
        private System.Windows.Forms.MenuStrip stripMenu;
        private System.Windows.Forms.ToolStripMenuItem tsFile;
        private System.Windows.Forms.ToolStripMenuItem tsOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsEdit;
        private System.Windows.Forms.ToolStripMenuItem tsAdditional;
        private System.Windows.Forms.Panel pTexture;
        private System.Windows.Forms.ToolStripMenuItem tsSaveAs;
        private System.Windows.Forms.ToolStripMenuItem tsDrawUV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trbHue;
        private System.Windows.Forms.Panel pEditBox;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Label lbFrameDurationValue;
        private System.Windows.Forms.Label lbFrameDuration;
        private System.Windows.Forms.TrackBar trbFrameDuration;
        private System.ComponentModel.BackgroundWorker bgwExtractFrames;
        private System.Windows.Forms.ListView lvFrames;
        private System.Windows.Forms.ToolStripProgressBar tsProgress;
        private System.Windows.Forms.Button btnChangeToTransparent;
        private System.Windows.Forms.ToolStripMenuItem tsView;
        private System.Windows.Forms.ToolStripMenuItem tsShowEditBox;
        private System.Windows.Forms.ToolStripMenuItem tsShowFrameBox;
        private System.Windows.Forms.Panel pFlagBox;
        private System.Windows.Forms.CheckedListBox clbFlag;
        private System.Windows.Forms.ToolStripMenuItem tsShowFlagBox;
        private System.Windows.Forms.ToolStripMenuItem tsSaveTexture;
        private System.Windows.Forms.ToolStripMenuItem tsImportUV;
        private System.Windows.Forms.ToolStripMenuItem tsAbout;
        private System.Windows.Forms.CheckBox cbOnlyCurrentFrame;
        private System.Windows.Forms.Label lbCurrentFrame;
        private System.Windows.Forms.Button btnPlayPauseAnimation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbFrameIcon;
        private System.Windows.Forms.ToolStripStatusLabel tslbIconPosition;
        private System.Windows.Forms.ToolStripMenuItem tsExportUV;
        public System.Windows.Forms.PictureBox pbTexture;
    }
}



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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.stripStatus = new System.Windows.Forms.StatusStrip();
            this.tslbStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsProgress = new System.Windows.Forms.ToolStripProgressBar();
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
            this.tsIconMode = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsImportUV = new System.Windows.Forms.ToolStripMenuItem();
            this.tsAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pbTexture = new System.Windows.Forms.PictureBox();
            this.pTexture = new System.Windows.Forms.Panel();
            this.pFlagBox = new System.Windows.Forms.Panel();
            this.cmsMovableControls = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsHide = new System.Windows.Forms.ToolStripMenuItem();
            this.clbFlag = new System.Windows.Forms.CheckedListBox();
            this.lvFrames = new System.Windows.Forms.ListView();
            this.pEditBox = new System.Windows.Forms.Panel();
            this.lbCurrentFrame = new System.Windows.Forms.Label();
            this.btnPlayPauseAnimation = new System.Windows.Forms.Button();
            this.cbOnlyCurrentFrame = new System.Windows.Forms.CheckBox();
            this.pColorPreview = new System.Windows.Forms.Panel();
            this.btnConvertToTransparent = new System.Windows.Forms.Button();
            this.lbFrameDurationValue = new System.Windows.Forms.Label();
            this.lbFrameDuration = new System.Windows.Forms.Label();
            this.trbFrameDuration = new System.Windows.Forms.TrackBar();
            this.btnUndo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.trbHue = new System.Windows.Forms.TrackBar();
            this.bgwExtractFrames = new System.ComponentModel.BackgroundWorker();
            this.stripStatus.SuspendLayout();
            this.stripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTexture)).BeginInit();
            this.pTexture.SuspendLayout();
            this.pFlagBox.SuspendLayout();
            this.cmsMovableControls.SuspendLayout();
            this.pEditBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbFrameDuration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trbHue)).BeginInit();
            this.SuspendLayout();
            // 
            // stripStatus
            // 
            this.stripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslbStatus,
            this.tsProgress,
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
            this.tsProgress.Size = new System.Drawing.Size(100, 16);
            this.tsProgress.Visible = false;
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
            this.tsIconMode,
            this.toolStripSeparator5,
            this.tsImportUV});
            this.tsAdditional.Name = "tsAdditional";
            this.tsAdditional.Size = new System.Drawing.Size(74, 20);
            this.tsAdditional.Text = "&Additional";
            // 
            // tsIconMode
            // 
            this.tsIconMode.Enabled = false;
            this.tsIconMode.Name = "tsIconMode";
            this.tsIconMode.Size = new System.Drawing.Size(131, 22);
            this.tsIconMode.Text = "Icon Mode";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(128, 6);
            // 
            // tsImportUV
            // 
            this.tsImportUV.Name = "tsImportUV";
            this.tsImportUV.Size = new System.Drawing.Size(131, 22);
            this.tsImportUV.Text = "Import UV";
            this.tsImportUV.Click += new System.EventHandler(this.tsImportUV_Click);
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
            this.pbTexture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbTexture.BackColor = System.Drawing.Color.Transparent;
            this.pbTexture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbTexture.Image = ((System.Drawing.Image)(resources.GetObject("pbTexture.Image")));
            this.pbTexture.Location = new System.Drawing.Point(282, 26);
            this.pbTexture.Name = "pbTexture";
            this.pbTexture.Size = new System.Drawing.Size(378, 178);
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
            this.pFlagBox.ContextMenuStrip = this.cmsMovableControls;
            this.pFlagBox.Controls.Add(this.clbFlag);
            this.pFlagBox.Location = new System.Drawing.Point(12, 29);
            this.pFlagBox.Name = "pFlagBox";
            this.pFlagBox.Size = new System.Drawing.Size(264, 351);
            this.pFlagBox.TabIndex = 13;
            this.pFlagBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovableControl_MouseDown);
            this.pFlagBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovableControl_MouseMove);
            // 
            // cmsMovableControls
            // 
            this.cmsMovableControls.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsHide});
            this.cmsMovableControls.Name = "contextMenuStrip1";
            this.cmsMovableControls.Size = new System.Drawing.Size(100, 26);
            // 
            // tsHide
            // 
            this.tsHide.Name = "tsHide";
            this.tsHide.Size = new System.Drawing.Size(99, 22);
            this.tsHide.Text = "Hide";
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
            this.pEditBox.Controls.Add(this.lbCurrentFrame);
            this.pEditBox.Controls.Add(this.btnPlayPauseAnimation);
            this.pEditBox.Controls.Add(this.cbOnlyCurrentFrame);
            this.pEditBox.Controls.Add(this.pColorPreview);
            this.pEditBox.Controls.Add(this.btnConvertToTransparent);
            this.pEditBox.Controls.Add(this.lbFrameDurationValue);
            this.pEditBox.Controls.Add(this.lbFrameDuration);
            this.pEditBox.Controls.Add(this.trbFrameDuration);
            this.pEditBox.Controls.Add(this.btnUndo);
            this.pEditBox.Controls.Add(this.label3);
            this.pEditBox.Controls.Add(this.trbHue);
            this.pEditBox.Location = new System.Drawing.Point(12, 387);
            this.pEditBox.Name = "pEditBox";
            this.pEditBox.Size = new System.Drawing.Size(264, 249);
            this.pEditBox.TabIndex = 11;
            this.pEditBox.Visible = false;
            this.pEditBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MovableControl_MouseDown);
            this.pEditBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MovableControl_MouseMove);
            // 
            // lbCurrentFrame
            // 
            this.lbCurrentFrame.BackColor = System.Drawing.Color.Transparent;
            this.lbCurrentFrame.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCurrentFrame.Location = new System.Drawing.Point(190, 0);
            this.lbCurrentFrame.Name = "lbCurrentFrame";
            this.lbCurrentFrame.Size = new System.Drawing.Size(73, 64);
            this.lbCurrentFrame.TabIndex = 18;
            this.lbCurrentFrame.Text = "#0";
            this.lbCurrentFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbCurrentFrame.Visible = false;
            // 
            // btnPlayPauseAnimation
            // 
            this.btnPlayPauseAnimation.Location = new System.Drawing.Point(8, 215);
            this.btnPlayPauseAnimation.Name = "btnPlayPauseAnimation";
            this.btnPlayPauseAnimation.Size = new System.Drawing.Size(95, 23);
            this.btnPlayPauseAnimation.TabIndex = 17;
            this.btnPlayPauseAnimation.Text = "Pause";
            this.btnPlayPauseAnimation.UseVisualStyleBackColor = true;
            this.btnPlayPauseAnimation.Visible = false;
            this.btnPlayPauseAnimation.Click += new System.EventHandler(this.btnPlayPauseAnimation_Click);
            // 
            // cbOnlyCurrentFrame
            // 
            this.cbOnlyCurrentFrame.Location = new System.Drawing.Point(14, 9);
            this.cbOnlyCurrentFrame.Name = "cbOnlyCurrentFrame";
            this.cbOnlyCurrentFrame.Size = new System.Drawing.Size(168, 24);
            this.cbOnlyCurrentFrame.TabIndex = 16;
            this.cbOnlyCurrentFrame.Text = "Modify only current frame";
            this.cbOnlyCurrentFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cbOnlyCurrentFrame.UseVisualStyleBackColor = true;
            this.cbOnlyCurrentFrame.Visible = false;
            // 
            // pColorPreview
            // 
            this.pColorPreview.BackColor = System.Drawing.Color.Black;
            this.pColorPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pColorPreview.Location = new System.Drawing.Point(14, 157);
            this.pColorPreview.Name = "pColorPreview";
            this.pColorPreview.Size = new System.Drawing.Size(21, 21);
            this.pColorPreview.TabIndex = 15;
            // 
            // btnConvertToTransparent
            // 
            this.btnConvertToTransparent.Location = new System.Drawing.Point(41, 156);
            this.btnConvertToTransparent.Name = "btnConvertToTransparent";
            this.btnConvertToTransparent.Size = new System.Drawing.Size(196, 23);
            this.btnConvertToTransparent.TabIndex = 14;
            this.btnConvertToTransparent.Text = "Change color to transparent";
            this.btnConvertToTransparent.UseVisualStyleBackColor = true;
            this.btnConvertToTransparent.Click += new System.EventHandler(this.btnConvertToTransparent_Click);
            // 
            // lbFrameDurationValue
            // 
            this.lbFrameDurationValue.BackColor = System.Drawing.Color.Transparent;
            this.lbFrameDurationValue.Location = new System.Drawing.Point(118, 101);
            this.lbFrameDurationValue.Name = "lbFrameDurationValue";
            this.lbFrameDurationValue.Size = new System.Drawing.Size(119, 15);
            this.lbFrameDurationValue.TabIndex = 13;
            this.lbFrameDurationValue.Text = "100 Milliseconds";
            this.lbFrameDurationValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lbFrameDurationValue.Visible = false;
            // 
            // lbFrameDuration
            // 
            this.lbFrameDuration.AutoSize = true;
            this.lbFrameDuration.BackColor = System.Drawing.Color.Transparent;
            this.lbFrameDuration.Location = new System.Drawing.Point(14, 101);
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
            this.trbFrameDuration.Location = new System.Drawing.Point(9, 119);
            this.trbFrameDuration.Maximum = 5000;
            this.trbFrameDuration.Minimum = 10;
            this.trbFrameDuration.Name = "trbFrameDuration";
            this.trbFrameDuration.Size = new System.Drawing.Size(235, 18);
            this.trbFrameDuration.TabIndex = 6;
            this.trbFrameDuration.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbFrameDuration.Value = 100;
            this.trbFrameDuration.Visible = false;
            this.trbFrameDuration.Scroll += new System.EventHandler(this.trbFrameDuration_Scroll);
            // 
            // btnUndo
            // 
            this.btnUndo.Location = new System.Drawing.Point(152, 215);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(95, 23);
            this.btnUndo.TabIndex = 11;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(14, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hue";
            // 
            // trbHue
            // 
            this.trbHue.AutoSize = false;
            this.trbHue.BackColor = System.Drawing.SystemColors.Control;
            this.trbHue.Location = new System.Drawing.Point(11, 68);
            this.trbHue.Maximum = 360;
            this.trbHue.Name = "trbHue";
            this.trbHue.Size = new System.Drawing.Size(235, 18);
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
            this.cmsMovableControls.ResumeLayout(false);
            this.pEditBox.ResumeLayout(false);
            this.pEditBox.PerformLayout();
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
        private System.Windows.Forms.PictureBox pbTexture;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
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
        private System.Windows.Forms.Button btnConvertToTransparent;
        private System.Windows.Forms.ToolStripMenuItem tsView;
        private System.Windows.Forms.ToolStripMenuItem tsShowEditBox;
        private System.Windows.Forms.ToolStripMenuItem tsShowFrameBox;
        private System.Windows.Forms.Panel pColorPreview;
        private System.Windows.Forms.Panel pFlagBox;
        private System.Windows.Forms.CheckedListBox clbFlag;
        private System.Windows.Forms.ContextMenuStrip cmsMovableControls;
        private System.Windows.Forms.ToolStripMenuItem tsHide;
        private System.Windows.Forms.ToolStripMenuItem tsShowFlagBox;
        private System.Windows.Forms.ToolStripMenuItem tsIconMode;
        private System.Windows.Forms.ToolStripMenuItem tsSaveTexture;
        private System.Windows.Forms.ToolStripMenuItem tsImportUV;
        private System.Windows.Forms.ToolStripMenuItem tsAbout;
        private System.Windows.Forms.CheckBox cbOnlyCurrentFrame;
        private System.Windows.Forms.Label lbCurrentFrame;
        private System.Windows.Forms.Button btnPlayPauseAnimation;
    }
}


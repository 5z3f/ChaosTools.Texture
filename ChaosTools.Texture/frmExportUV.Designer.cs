
namespace ChaosTools.Texture
{
    partial class frmExportUV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbPreview = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbWireframe = new System.Windows.Forms.RadioButton();
            this.rbWireframeSurfaces = new System.Windows.Forms.RadioButton();
            this.rbWireframeTexture = new System.Windows.Forms.RadioButton();
            this.pbSurfaceColor = new System.Windows.Forms.PictureBox();
            this.pbWireframeColor = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            this.rbSurfaces = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSurfaceColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWireframeColor)).BeginInit();
            this.SuspendLayout();
            // 
            // pbPreview
            // 
            this.pbPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbPreview.Location = new System.Drawing.Point(12, 12);
            this.pbPreview.Name = "pbPreview";
            this.pbPreview.Size = new System.Drawing.Size(300, 300);
            this.pbPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPreview.TabIndex = 0;
            this.pbPreview.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(331, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "UV Map Exporter";
            // 
            // rbWireframe
            // 
            this.rbWireframe.AutoSize = true;
            this.rbWireframe.Checked = true;
            this.rbWireframe.Location = new System.Drawing.Point(331, 53);
            this.rbWireframe.Name = "rbWireframe";
            this.rbWireframe.Size = new System.Drawing.Size(108, 19);
            this.rbWireframe.TabIndex = 2;
            this.rbWireframe.TabStop = true;
            this.rbWireframe.Text = "Wireframe Only";
            this.rbWireframe.UseVisualStyleBackColor = true;
            this.rbWireframe.CheckedChanged += new System.EventHandler(this.rbOptions_CheckedChanged);
            // 
            // rbWireframeSurfaces
            // 
            this.rbWireframeSurfaces.AutoSize = true;
            this.rbWireframeSurfaces.Location = new System.Drawing.Point(331, 103);
            this.rbWireframeSurfaces.Name = "rbWireframeSurfaces";
            this.rbWireframeSurfaces.Size = new System.Drawing.Size(138, 19);
            this.rbWireframeSurfaces.TabIndex = 3;
            this.rbWireframeSurfaces.Text = "Wireframe + Surfaces";
            this.rbWireframeSurfaces.UseVisualStyleBackColor = true;
            this.rbWireframeSurfaces.CheckedChanged += new System.EventHandler(this.rbOptions_CheckedChanged);
            // 
            // rbWireframeTexture
            // 
            this.rbWireframeTexture.AutoSize = true;
            this.rbWireframeTexture.Location = new System.Drawing.Point(331, 78);
            this.rbWireframeTexture.Name = "rbWireframeTexture";
            this.rbWireframeTexture.Size = new System.Drawing.Size(132, 19);
            this.rbWireframeTexture.TabIndex = 4;
            this.rbWireframeTexture.Text = "Wireframe + Texture";
            this.rbWireframeTexture.UseVisualStyleBackColor = true;
            this.rbWireframeTexture.CheckedChanged += new System.EventHandler(this.rbOptions_CheckedChanged);
            // 
            // pbSurfaceColor
            // 
            this.pbSurfaceColor.BackColor = System.Drawing.Color.White;
            this.pbSurfaceColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbSurfaceColor.Location = new System.Drawing.Point(331, 190);
            this.pbSurfaceColor.Name = "pbSurfaceColor";
            this.pbSurfaceColor.Size = new System.Drawing.Size(20, 20);
            this.pbSurfaceColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSurfaceColor.TabIndex = 5;
            this.pbSurfaceColor.TabStop = false;
            this.pbSurfaceColor.Click += new System.EventHandler(this.pbSurfaceColor_Click);
            // 
            // pbWireframeColor
            // 
            this.pbWireframeColor.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbWireframeColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbWireframeColor.Location = new System.Drawing.Point(331, 216);
            this.pbWireframeColor.Name = "pbWireframeColor";
            this.pbWireframeColor.Size = new System.Drawing.Size(20, 20);
            this.pbWireframeColor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbWireframeColor.TabIndex = 6;
            this.pbWireframeColor.TabStop = false;
            this.pbWireframeColor.Click += new System.EventHandler(this.pbWireframeColor_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(357, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Surface";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(357, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Wireframe";
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(640, 289);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(148, 23);
            this.btnExport.TabIndex = 9;
            this.btnExport.Text = "Export as PNG";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // rbSurfaces
            // 
            this.rbSurfaces.AutoSize = true;
            this.rbSurfaces.Location = new System.Drawing.Point(331, 128);
            this.rbSurfaces.Name = "rbSurfaces";
            this.rbSurfaces.Size = new System.Drawing.Size(97, 19);
            this.rbSurfaces.TabIndex = 10;
            this.rbSurfaces.Text = "Surfaces Only";
            this.rbSurfaces.UseVisualStyleBackColor = true;
            // 
            // frmExportUV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 326);
            this.Controls.Add(this.rbSurfaces);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbWireframeColor);
            this.Controls.Add(this.pbSurfaceColor);
            this.Controls.Add(this.rbWireframeTexture);
            this.Controls.Add(this.rbWireframeSurfaces);
            this.Controls.Add(this.rbWireframe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmExportUV";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSurfaceColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWireframeColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPreview;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbWireframe;
        private System.Windows.Forms.RadioButton rbWireframeSurfaces;
        private System.Windows.Forms.RadioButton rbWireframeTexture;
        private System.Windows.Forms.PictureBox pbSurfaceColor;
        private System.Windows.Forms.PictureBox pbWireframeColor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.RadioButton rbSurface;
        private System.Windows.Forms.RadioButton rbSurfaces;
    }
}
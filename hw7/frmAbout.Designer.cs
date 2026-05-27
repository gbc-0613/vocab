namespace hw7
{
    partial class frmAbout
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBottom = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.SuspendLayout();

            // picLogo
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(120, 140);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabStop = false;

            // lblAppName
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblAppName.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblAppName.Location = new System.Drawing.Point(130, 15);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Text = "WordCards";

            // lblVersion
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblVersion.Location = new System.Drawing.Point(133, 55);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Text = "Version 1.0.0";

            // lblDescription
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblDescription.Location = new System.Drawing.Point(133, 80);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Text = "英文單字卡學習系統";

            // lblCopyright
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblCopyright.ForeColor = System.Drawing.Color.Gray;
            this.lblCopyright.Location = new System.Drawing.Point(133, 108);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Text = "© 2025 Windows Programming (II)";

            // panelTop
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.picLogo);
            this.panelTop.Controls.Add(this.lblAppName);
            this.panelTop.Controls.Add(this.lblVersion);
            this.panelTop.Controls.Add(this.lblDescription);
            this.panelTop.Controls.Add(this.lblCopyright);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(384, 140);

            // btnOK
            this.btnOK.Location = new System.Drawing.Point(156, 8);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 28);
            this.btnOK.Text = "確定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);

            // panelBottom
            this.panelBottom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBottom.Controls.Add(this.btnOK);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(384, 45);

            // frmAbout
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 185);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About WordCards";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCopyright;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelBottom;
    }
}

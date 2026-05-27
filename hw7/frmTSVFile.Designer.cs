namespace hw7
{
    partial class frmTSVFile
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
            this.mnsWord    = new System.Windows.Forms.MenuStrip();
            this.tsmiFile   = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOpen   = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit   = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp   = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout  = new System.Windows.Forms.ToolStripMenuItem();
            this.lvwWord    = new System.Windows.Forms.ListView();
            this.colWord    = new System.Windows.Forms.ColumnHeader();
            this.colPhonogram = new System.Windows.Forms.ColumnHeader();
            this.colSoundPath = new System.Windows.Forms.ColumnHeader();
            this.colExplain  = new System.Windows.Forms.ColumnHeader();
            this.ssrWord    = new System.Windows.Forms.StatusStrip();
            this.tsslMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnsWord.SuspendLayout();
            this.ssrWord.SuspendLayout();
            this.SuspendLayout();

            // ── mnsWord (MenuStrip) ──────────────────────────────
            this.mnsWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmiFile,
                this.tsmiHelp
            });
            this.mnsWord.Dock = System.Windows.Forms.DockStyle.Top;
            this.mnsWord.Name = "mnsWord";
            this.mnsWord.Size = new System.Drawing.Size(900, 24);

            // ── tsmiFile ─────────────────────────────────────────
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmiOpen,
                this.toolStripSeparator1,
                this.tsmiExit
            });
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Text = "File";

            // ── tsmiOpen ─────────────────────────────────────────
            this.tsmiOpen.Name = "tsmiOpen";
            this.tsmiOpen.Text = "Open...";
            this.tsmiOpen.ShortcutKeys = System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O;
            this.tsmiOpen.Click += new System.EventHandler(this.tsmiOpen_Click);

            // ── toolStripSeparator1 ───────────────────────────────
            this.toolStripSeparator1.Name = "toolStripSeparator1";

            // ── tsmiExit ─────────────────────────────────────────
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Text = "Exit";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);

            // ── tsmiHelp ─────────────────────────────────────────
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsmiAbout
            });
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Text = "Help";

            // ── tsmiAbout ────────────────────────────────────────
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Text = "About...";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);

            // ── lvwWord (ListView) ───────────────────────────────
            this.lvwWord.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
                this.colWord,
                this.colPhonogram,
                this.colSoundPath,
                this.colExplain
            });
            this.lvwWord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvwWord.FullRowSelect = true;
            this.lvwWord.GridLines = true;
            this.lvwWord.View = System.Windows.Forms.View.Details;
            this.lvwWord.Name = "lvwWord";

            // ── Columns ──────────────────────────────────────────
            this.colWord.Text = "Word";
            this.colWord.Width = 130;

            this.colPhonogram.Text = "Phonogram";
            this.colPhonogram.Width = 130;

            this.colSoundPath.Text = "SoundPath";
            this.colSoundPath.Width = 180;

            this.colExplain.Text = "Explain";
            this.colExplain.Width = 400;

            // ── ssrWord (StatusStrip) ────────────────────────────
            this.ssrWord.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.tsslMessage
            });
            this.ssrWord.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ssrWord.Name = "ssrWord";

            // ── tsslMessage ───────────────────────────────────────
            this.tsslMessage.Name = "tsslMessage";
            this.tsslMessage.Text = "";

            // ── frmTSVFile ────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.lvwWord);
            this.Controls.Add(this.mnsWord);
            this.Controls.Add(this.ssrWord);
            this.MainMenuStrip = this.mnsWord;
            this.Name = "frmTSVFile";
            this.Text = "TSVFile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTSVFile_FormClosing);
            this.Load += new System.EventHandler(this.frmTSVFile_Load);
            this.mnsWord.ResumeLayout(false);
            this.mnsWord.PerformLayout();
            this.ssrWord.ResumeLayout(false);
            this.ssrWord.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsWord;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiOpen;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ListView lvwWord;
        private System.Windows.Forms.ColumnHeader colWord;
        private System.Windows.Forms.ColumnHeader colPhonogram;
        private System.Windows.Forms.ColumnHeader colSoundPath;
        private System.Windows.Forms.ColumnHeader colExplain;
        private System.Windows.Forms.StatusStrip ssrWord;
        private System.Windows.Forms.ToolStripStatusLabel tsslMessage;
    }
}

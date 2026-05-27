using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace hw7
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        private void frmAbout_Load(object sender, EventArgs e)
        {
            // 嘗試載入 Logo 圖片
            string logoPath = Path.Combine(Application.StartupPath, "07_wordcards", "WordCards_Logo.png");
            if (File.Exists(logoPath))
            {
                picLogo.Image = Image.FromFile(logoPath);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

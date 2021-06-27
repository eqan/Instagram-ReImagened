using System;
using System.Drawing;
using System.Windows.Forms;

namespace Instagram
{
    public partial class ProfilePreview : Form
    {
        bool lightModeOn;
        public ProfilePreview(bool lightModeOn)
        {
            InitializeComponent();
            this.lightModeOn = lightModeOn;
            Configure_Theme();
        }
        private void Configure_Theme()
        {
            Color backColor, textColor, barColor;
            if (lightModeOn)
            {
                backColor = Color.FromArgb(242, 242, 242);
                textColor = Color.FromArgb(0, 0, 0);
                barColor = Color.FromArgb(209, 209, 209);
            }
            else
            {
                backColor = Color.FromArgb(43, 43, 43);
                textColor = Color.FromArgb(255, 255, 255);
                barColor = Color.FromArgb(31, 31, 31);
            }
            this.BackColor = backColor;
            userNameLabel.ForeColor = textColor;
            topBar.BackColor = barColor;
            bottomBar.BackColor = barColor;
        }

        private void SearchResult_Load(object sender, EventArgs e)
        {

        }

        private void realUserNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void profilePictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}

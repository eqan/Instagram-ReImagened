using System;
using System.Drawing;
using System.Windows.Forms;

namespace Instagram
{
    public partial class ProfilePreview : Form
    {
        bool lightModeOn;
        Main main;
        public string userId, userName, realUserName;
        DBHandlingUtilities dbHandler;
        public ProfilePreview(Main main)
        {
            InitializeComponent();
            this.dbHandler = new DBHandlingUtilities();
            this.lightModeOn = main.lightModeOn;
            this.main = main;
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
            main.form.Dispose();
            main.form = new Profile(main, true, this.userId, this.userName) { TopLevel = false, TopMost = true };;
        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {
            main.form.Dispose();
            main.form = new Profile(main, true, this.userId, this.userName) { TopLevel = false, TopMost = true };;
        }

        private void profilePictureBox_Click(object sender, EventArgs e)
        {
            main.form.Dispose();
            main.form = new Profile(main, true, this.userId, this.userName) { TopLevel = false, TopMost = true };;
        }
    }
}

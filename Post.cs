using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Instagram
{
    public partial class Post : Form
    {
        [DllImport("user32.dll")]
        static extern bool HideCaret(IntPtr hWnd);
        bool lightModeOn = true;
        UIUtilities UI;
        DBHandlingUtilities dbHandler;
        public string postID, followingID, userID, userName;
        public Post(string userID, string userName, bool lightModeOn)
        {
            InitializeComponent();
            this.userID = userID;
            this.userName = userName;
            this.lightModeOn = lightModeOn;
            UI = new UIUtilities(this.lightModeOn);
            dbHandler = new DBHandlingUtilities();
            Configure_Theme();
        }

        private void Configure_Theme()
        {
            Color backColor, textColor, barColor;
            if (lightModeOn)
            {
                backColor = Color.FromArgb(242, 242, 242);
                textColor = Color.FromArgb(0, 0, 0);
                barColor = Color.FromArgb(255, 255, 255);
            }
            else
            {
                backColor = Color.FromArgb(43, 43, 43);
                textColor = Color.FromArgb(255, 255, 255);
                barColor = Color.FromArgb(0, 0, 0);
            }    
            this.BackColor = backColor;
            postDescriptionBox.BackColor = backColor;
            userNameLabel.ForeColor = textColor;
            postDescriptionBox.ForeColor = textColor;
            timeLabel.ForeColor = textColor;
            locationLabel.ForeColor = textColor;
            likeLabel.ForeColor = textColor;
            postDescriptionBox.Cursor = Cursors.Arrow;
            likeBtn.Image = Image.FromFile(UI.Return_UI_Location() + "heart.png");
            bookMarkedBtn.Image = Image.FromFile(UI.Return_UI_Location() + "bookmark.png");
            topBar.BackColor = barColor;
            bottomBar.BackColor = barColor;
        }


        private void likeBtn_MouseHover(object sender, EventArgs e)
        {
            likeBtn.Image.Dispose();
            likeBtn.Image = Image.FromFile(Environment.CurrentDirectory + @"\Assets\Selected Mode\heart.png");
        }

        private void likeBtn_MouseLeave(object sender, EventArgs e)
        {
            likeBtn.Image.Dispose();
            likeBtn.Image = Image.FromFile(UI.Return_UI_Location() + "heart.png");
        }

        private void likeBtn_Click(object sender, EventArgs e)
        {
            dbHandler.Add_Like(userID, userName, followingID, userNameLabel.Text, postID);
        }

        private void bookMarkedBtn_MouseHover(object sender, EventArgs e)
        {
            bookMarkedBtn.Image.Dispose();
            bookMarkedBtn.Image = Image.FromFile(Environment.CurrentDirectory + @"\Assets\Selected Mode\bookmark.png");
        }

        private void bookMarkedBtn_MouseLeave(object sender, EventArgs e)
        {
            bookMarkedBtn.Image.Dispose();
            bookMarkedBtn.Image = Image.FromFile(UI.Return_UI_Location() + "bookmark.png");
        }

        private void bookMarkedBtn_Click(object sender, EventArgs e)
        {
            dbHandler.Add_BookMark(userID, userName, followingID, userNameLabel.Text, postID);
        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void postDescriptionBox_TextChanged(object sender, EventArgs e)
        {
            HideCaret(postDescriptionBox.Handle);
        }
    }
}

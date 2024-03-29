﻿using System;
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
        public Main main;
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
                barColor = Color.FromArgb(209, 209, 209);
            }
            else
            {
                backColor = Color.FromArgb(43, 43, 43);
                textColor = Color.FromArgb(255, 255, 255);
                barColor = Color.FromArgb(31, 31, 31);
            }
            this.BackColor = backColor;
            postDescriptionBox.BackColor = backColor;
            userNameLabel.ForeColor = textColor;
            postDescriptionBox.ForeColor = textColor;
            timeLabel.ForeColor = textColor;
            locationLabel.ForeColor = textColor;
            likeLabel.ForeColor = textColor;
            postDescriptionBox.Cursor = Cursors.Arrow;
            menuBtn.Image = Image.FromFile(UI.Return_UI_Location() + "more.png");
            likeBtn.Image = Image.FromFile(UI.Return_UI_Location() + "heart.png");
            bookMarkedBtn.Image = Image.FromFile(UI.Return_UI_Location() + "bookmark.png");
            topBar.BackColor = barColor;
            bottomBar.BackColor = barColor;
        }


        private void likeBtn_MouseHover(object sender, EventArgs e)
        {
            //likeBtn.Image.Dispose();
            //likeBtn.Image = Image.FromFile(Environment.CurrentDirectory + @"\Assets\Selected Mode\heart.png");
        }

        private void likeBtn_MouseLeave(object sender, EventArgs e)
        {
            //likeBtn.Image.Dispose();
            //likeBtn.Image = Image.FromFile(UI.Return_UI_Location() + "heart.png");
        }

        private void likeBtn_Click(object sender, EventArgs e)
        {
            bool result = dbHandler.Add_Like(userID, userName, followingID, userNameLabel.Text, postID);
            if(result)
            {
                Console.WriteLine("Reached here");
                likeLabel.Text = (Int32.Parse(likeLabel.Text) + 1).ToString() + " Likes";
                likeBtn.Image = Image.FromFile(Environment.CurrentDirectory + @"\Assets\Selected Mode\heart.png");
            }
            else
            {
                Console.WriteLine("Reached here");
                likeLabel.Text = (Int32.Parse(likeLabel.Text) - 1).ToString() + " Likes";
                likeBtn.Image = Image.FromFile(Environment.CurrentDirectory + @"\Assets\Selected Mode\heart.png");
            }
        }

        private void bookMarkedBtn_MouseHover(object sender, EventArgs e)
        {
            //bookMarkedBtn.Image.Dispose();
            //bookMarkedBtn.Image = Image.FromFile(Environment.CurrentDirectory + @"\Assets\Selected Mode\bookmark.png");
        }

        private void bookMarkedBtn_MouseLeave(object sender, EventArgs e)
        {
            //bookMarkedBtn.Image.Dispose();
            //bookMarkedBtn.Image = Image.FromFile(UI.Return_UI_Location() + "bookmark.png");
        }

        private void menuBtn_MouseHover(object sender, EventArgs e)
        {
            if (userID == main?.userID)
            {
                menuBtn.Image.Dispose();
                menuBtn.Image = Image.FromFile(Environment.CurrentDirectory + @"\Assets\Selected Mode\more.png");
            }
            else
            {
                this.menuBtn.Dispose();
            }
        }

        private void menuBtn_MouseLeave(object sender, EventArgs e)
        {
            if(userID == main?.userID)
            {
                menuBtn.Image.Dispose();
                menuBtn.Image = Image.FromFile(UI.Return_UI_Location() + "more.png");
            }
            else
            {
                this.menuBtn.Dispose();
            }
        }

        private void menuBtn_Click(object sender, EventArgs e)
        {
            if(userID == main?.userID)
            {
                ConfirmationDialog dialog = new ConfirmationDialog(false, "delete this post?");
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Remove post from db
                    // Refresh the main page
                    dbHandler.Remove_Post(userID, userName, postID);
                    this.main.form.Dispose();
                    this.main.form = new Home(main) { TopLevel = false, TopMost = true };
                }
            }
            else
            {
                this.menuBtn.Dispose();
            }
        }

        private void bookMarkedBtn_Click(object sender, EventArgs e)
        {
            bool result = dbHandler.Add_BookMark(userID, userName, followingID, userNameLabel.Text, postID);
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

using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;

namespace Instagram
{
    public partial class Profile : Form
    {
        int listViewItemsCount = 0;
        ImageList listViewImageList = new ImageList();
        DBHandlingUtilities dbHandler;
        UIUtilities UI;
        string ImageNewName = "";
        Main main;
        public Profile(Main main)
        {
            InitializeComponent();
            userNameLabel.Text = main.userName;
            dbHandler = new DBHandlingUtilities();
            this.main = main;
            Configure_Theme();
            Retrieve_Profile_Information();
            Add_All_Posts_ThumbNail(main.userID, main.userName);
        }

        private void Configure_Theme()
        {
            UI = new UIUtilities(main.lightModeOn);
            Color backColor, textColor, barColor;
            if (main.lightModeOn)
            {
                barColor = Color.FromArgb(242, 242, 242);
                textColor = Color.FromArgb(0, 0, 0);
                backColor = Color.FromArgb(209, 209, 209);
                themeBtn.Text = "Dark Mode";
                themeBtn.BackColor = Color.FromArgb(105, 105, 105);
                themeBtn.Image = Image.FromFile(UI.Return_UI_Location() + "moon.png");
            }
            else
            {
                barColor = Color.FromArgb(43, 43, 43);
                textColor = Color.FromArgb(255, 255, 255);
                backColor = Color.FromArgb(31, 31, 31);
                themeBtn.Text = "Light Mode";
                themeBtn.BackColor = Color.FromArgb(141, 177, 246);
                themeBtn.Image = Image.FromFile(UI.Return_UI_Location() + "sun.png");
            }
            UI = new UIUtilities(main.lightModeOn);
            this.BackColor = backColor;
            realUserNameLabel.ForeColor = userNameLabel.ForeColor = followersCountLabel.ForeColor = followingCountLabel.ForeColor = postCountLabel.ForeColor = textColor;
            followersIndicatorLabel.ForeColor = followingIndicatorLabel.ForeColor = postIndicatorLabel.ForeColor = taglineBox.ForeColor = textColor;
            taglineBox.BackColor = postFeed.BackColor = backColor;
            bookMarkBtn.FlatAppearance.BorderSize = streamViewBtn.FlatAppearance.BorderSize = gridViewBtn.FlatAppearance.BorderSize = 0;
            bookMarkBtn.FlatStyle = streamViewBtn.FlatStyle = gridViewBtn.FlatStyle = FlatStyle.Flat;
            bookMarkBtn.BackColor = streamViewBtn.BackColor = gridViewBtn.BackColor = barColor;
        }


        public void Retrieve_Profile_Information()
        {
            List<string> profileInformation = dbHandler.Return_Profile_Information(main.userID, main.userName);
            profilePictureBox.Bitmap = new Bitmap(dbHandler.Retrieve_Profile_Picture_Using_SQL(Int32.Parse(main.userID)));
            userNameLabel.Text = main.userName;
            try
            {
                followingCountLabel.Text = profileInformation[0];
                followersCountLabel.Text = profileInformation[1];
                postCountLabel.Text = profileInformation[2];
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                followingCountLabel.Text = "0";
                followersCountLabel.Text = "0"; 
                postCountLabel.Text = "0";
            }
            realUserNameLabel.Text = profileInformation[3];
            taglineBox.Text = profileInformation[4];
        }

        private void Add_All_Posts_ThumbNail(string userID, string userName)
        {
            listViewImageList.ImageSize = new Size(150, 150);
            Image[] images = dbHandler.Retrieve_All_Pictures((userName + "_" + userID + "_PostTable"), "PostID");
            for (int i = 0; i < images.Length; i++)
            {
                try
                {
                    listViewImageList.Images.Add(images[i]);
                    postFeed.Items.Add(new ListViewItem
                    {
                        ImageIndex = listViewItemsCount,
                        Tag = images[i].Tag.ToString()
                    }); ; ; ; ; ; ;
                    listViewItemsCount++;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            postFeed.LargeImageList = listViewImageList;
        }

        private void editProfile_Click(object sender, EventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            if (main.lightModeOn)
                main.lightModeOn = false;
            else
                main.lightModeOn = true;
            Configure_Theme();
            main.Configure_Theme();
        }

        private void listView1_AfterLabelEdit(object sender, LabelEditEventArgs e)
        {
            if (e.Label == null)
                return;
            ImageNewName = Convert.ToString(e.Label);
            ListViewItem item1 = postFeed.SelectedItems[0];
            FileInfo fileInfo = new FileInfo(item1.Tag.ToString());
            fileInfo.MoveTo(fileInfo.Directory.FullName + "\\" + ImageNewName + fileInfo.Extension);
            postFeed.Items[listViewItemsCount].Text = ImageNewName;
        }


        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (postFeed.SelectedIndices.Count <= 0)
            {
                Console.WriteLine(postFeed.SelectedItems.Count);
                return;
            }
            if (postFeed.SelectedIndices[0] >= 0)
            {
                var item = postFeed.SelectedItems[0];
                string postID = item.Tag.ToString();
                main.form.Dispose();
                main.form = dbHandler.Return_Post(main.userID, main.userName, main.lightModeOn, postID);
            }
        }
    }
}

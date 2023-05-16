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
        string externalUserId, externalUserName;
        bool isExternalProfile;
        public Profile(Main main, bool isExternalProfile = false, string _userId = null, string _userName = null)
        {
            InitializeComponent();
            dbHandler = new DBHandlingUtilities();
            this.main = main;
            this.isExternalProfile = isExternalProfile;
            if (isExternalProfile)
            {
                this.externalUserId = _userId;
                this.externalUserName = _userName;
                this.themeBtn.Visible = false;
                Change_Button_According_To_Data(dbHandler.Check_If_User_Followed_Or_Not(main.userID, main.userName, _userId));
            }
            else
            {
                this.externalUserId = main.userID;
                this.externalUserName = main.userName;
            }
            userNameLabel.Text = this.externalUserId;
            Configure_Theme();
            Retrieve_Profile_Information(this.externalUserId, this.externalUserName);
            Add_All_Posts_ThumbNail(this.externalUserId, this.externalUserName);
        }

        private void Change_Button_According_To_Data(bool isFollowed, bool isChangeOnRunTime = false)
        {
            if (isFollowed)
            {
                this.editProfileBtn.Text = "Following";
                this.editProfileBtn.BackgroundColor = Color.DodgerBlue;
                if (isChangeOnRunTime)
                {
                    this.followersCountLabel.Text = (Int32.Parse(this.followersCountLabel.Text) + 1).ToString();
                }
            }
            else
            {
                this.editProfileBtn.Text = "Follow";
                this.editProfileBtn.BackgroundColor = Color.DarkBlue;
                dbHandler.Truncate_Temporary_Post_Table();
                dbHandler.Create_View_For_Following_Posts(main.userID, main.userName);
                if (isChangeOnRunTime)
                {
                    this.followersCountLabel.Text = (Int32.Parse(this.followersCountLabel.Text) - 1).ToString();
                }
            }
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


        public void Retrieve_Profile_Information(string userId, string userName)
        {
            Console.WriteLine(userId + " " + userName);
            List<string> profileInformation = dbHandler.Return_Profile_Information(userId, userName);
            profilePictureBox.Bitmap = new Bitmap(dbHandler.Retrieve_Profile_Picture_Using_SQL(Int32.Parse(main.userID)));
            userNameLabel.Text = userName;
            try
            {
                followingCountLabel.Text = profileInformation[0];
                followersCountLabel.Text = profileInformation[1];
                postCountLabel.Text = profileInformation[2];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                followingCountLabel.Text = "0";
                followersCountLabel.Text = "0";
                postCountLabel.Text = "0";
            }
            try
            {
                realUserNameLabel.Text = profileInformation[3];
                taglineBox.Text = profileInformation[4];
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                realUserNameLabel.Text = "";
                taglineBox.Text = "";
            }
        }

        private void Add_All_Posts_ThumbNail(string userID, string userName)
        {
            listViewImageList.ImageSize = new Size(150, 150);
            Image[] images = dbHandler.Retrieve_All_Pictures((userName + "_" + userID + "_PostTable"), "PostID", "ORDER BY TimeLine DESC");
            if (images != null && images.Length > 0)
            {
                try
                {
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
            if (isExternalProfile)
            {
                bool result = dbHandler.Return_True_If_Added_To_Following_Otherwise_False_If_Removed(main.userID, main.userName, this.externalUserId, this.externalUserName);
                Change_Button_According_To_Data(result, true);
            }
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
                main.form = dbHandler.Return_Post(externalUserId, externalUserName, main.lightModeOn, postID, main);
            }
        }
    }
}

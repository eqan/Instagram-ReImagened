using System;
using System.Drawing;
using System.Windows.Forms;

namespace Instagram
{
    public partial class AddStory : Form
    {
        DBHandlingUtilities dbHandler;
        UIUtilities UI;
        bool lightModeOn;
        string userID = "5", userName = "Ahmad";
        public AddStory(string userID, string userName, bool lightModeOn)
        {
            InitializeComponent();
            dbHandler = new DBHandlingUtilities();
            UI = new UIUtilities(lightModeOn);
            this.lightModeOn = lightModeOn;
            this.userID = userID;
            this.userName = userName;
            Configure_Theme();
        }
        private void Configure_Theme()
        {
            Color backColor;
            if (lightModeOn)
            {
                backColor = Color.FromArgb(209, 209, 209);
                albumBtn.BackColor = Color.FromArgb(227, 227, 227);
            }
            else
            {
                backColor = Color.FromArgb(31, 31, 31);
                albumBtn.BackColor = Color.FromArgb(43, 43, 43);
            }
            this.BackColor = backColor;
            storyBox.BackColor = backColor;
            uploadBtn.Image = Image.FromFile(UI.Return_UI_Location() + "upload.png"); 
            albumBtn.Image = Image.FromFile(UI.Return_UI_Location() + "album.png"); 
        }


        private void upload_Click(object sender, EventArgs e)
        {
            if (storyBox.Image != null)
            {
                dbHandler.Add_Story(userID, userName);
                this.Dispose();
            }
            else
                MessageBox.Show("Image not Uploaded!", "Post Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void album_Click(object sender, EventArgs e)
        {
            try
            {
                dbHandler.Get_Picture();
                storyBox.Image = Image.FromFile(dbHandler.fileDirectory);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Post Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

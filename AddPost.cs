using System;
using System.Drawing;
using System.Windows.Forms;

namespace Instagram
{
    public partial class AddPost : Form
    {
        bool lightModeOn = true;
        UIUtilities UI;
        DBHandlingUtilities dbHandler;
        string userName, userID;
        public AddPost(string userID, string userName, bool lightModeOn)
        {
            InitializeComponent();
            this.userName = userName;
            this.userID = userID;
            UI = new UIUtilities(lightModeOn);
            dbHandler = new DBHandlingUtilities();
            this.lightModeOn = lightModeOn;
            Configure_Page();
            Configure_Theme();
        }
        private void Configure_Theme()
        {
            Color backColor, textColor;
            if (lightModeOn)
            {
                backColor = Color.FromArgb(209, 209, 209);
                textColor = Color.FromArgb(0, 0, 0);
            }
            else
            {
                backColor = Color.FromArgb(31, 31, 31);
                textColor = Color.FromArgb(255, 255, 255);
            }
            this.BackColor = backColor;
            postDescritpionLabel.BackColor = backColor;
            locationLabel.BackColor = backColor;
            locationBox.BackColor = backColor;
            userNameLabel.BackColor = backColor;
            postDescritpionBox.BackColor = backColor;
            userNameLabel.ForeColor = textColor;
            postDescritpionLabel.ForeColor = textColor;
            locationLabel.ForeColor = textColor;
            postDescritpionBox.ForeColor = textColor;
            locationBox.ForeColor = textColor;
            postPictureBox.BackColor = backColor;
            nextBtn.Image = Image.FromFile(UI.Return_UI_Location() + "next.png");
        }

        private void Configure_Page()
        {
            userNameLabel.Text = userName;
            profilePictureBox.Bitmap = (Bitmap)dbHandler.Retrieve_Profile_Picture_Using_SQL(Int32.Parse(userID));
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            nextBtn.Image.Dispose();
            nextBtn.Image = Image.FromFile(Environment.CurrentDirectory + @"\Assets\Selected Mode\next.png");
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (postPictureBox.Image != null)
            {
                dbHandler.Add_Post(userID, userName, postDescritpionBox.Text, locationBox.Text);
                this.Dispose();
            }
            else
                MessageBox.Show("Image not Uploaded!", "Post Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void uploadPictureBtn_Click(object sender, EventArgs e)
        {
            try
            {
                dbHandler.Get_Picture();
                postPictureBox.Image = Image.FromFile(dbHandler.fileDirectory);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Post Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void nextBtn_MouseLeave(object sender, EventArgs e)
        {
            nextBtn.Image.Dispose();
            nextBtn.Image = Image.FromFile(UI.Return_UI_Location() + "next.png");
        }
    }
}

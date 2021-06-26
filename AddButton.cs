using System;
using System.Drawing;
using System.Windows.Forms;

namespace Instagram
{
    public partial class AddButton : Form
    {
        bool lightModeOn = false;
        UIUtilities UI;
        Main main;
        public AddButton(Main main)
        {
            InitializeComponent();
            this.lightModeOn = main.lightModeOn;
            UI = new UIUtilities(lightModeOn);
            this.main = main;
            Configure_Theme();
        }
        private void Configure_Theme()
        {
            Color backColor;
            if (lightModeOn)
                backColor = Color.FromArgb(209, 209, 209);
            else
                backColor = Color.FromArgb(31, 31, 31);
            this.BackColor = backColor;
            pictureBox3.Image = Image.FromFile(UI.Return_UI_Location() + @"\left-half-triangle.png");
            pictureBox2.Image = Image.FromFile(UI.Return_UI_Location() + @"\right-half-triangle.png");
        }


        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image.Dispose();
            pictureBox3.Image = Image.FromFile(Environment.CurrentDirectory + @"\Assets\Selected Mode\left-half-triangle.png");
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image.Dispose();
            pictureBox3.Image = Image.FromFile(UI.Return_UI_Location() + @"\left-half-triangle.png");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            AddPost addPost = new AddPost(main.userID, main.userName, lightModeOn) { TopLevel = false, TopMost = true };;
            main.formVirtualizer.Controls.Add(addPost);
            addPost.Show();
            this.Dispose();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image.Dispose();
            pictureBox2.Image = Image.FromFile(Environment.CurrentDirectory + @"\Assets\Selected Mode\right-half-triangle.png");
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image.Dispose();
            pictureBox2.Image = Image.FromFile(UI.Return_UI_Location() + @"\right-half-triangle.png");
        }
    }
}

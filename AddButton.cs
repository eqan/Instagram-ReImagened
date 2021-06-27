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
        Panel panelRef;
        public AddButton(Main main)
        {
            InitializeComponent();
            this.lightModeOn = main.lightModeOn;
            UI = new UIUtilities(lightModeOn);
            this.main = main;
            Configure_Theme();
        }

        public void Add_Panel_Reference(Panel panel)
        {
            this.panelRef = panel;
        }

        private void Configure_Theme()
        {
            Color backColor;
            if (lightModeOn)
                backColor = Color.FromArgb(209, 209, 209);
            else
                backColor = Color.FromArgb(31, 31, 31);
            this.BackColor = backColor;
            addPostBtn.Image = Image.FromFile(UI.Return_UI_Location() + @"\left-half-triangle.png");
            addStoryBtn.Image = Image.FromFile(UI.Return_UI_Location() + @"\right-half-triangle.png");
        }

        private void Reset_Color()
        {
            Color backColor;
            if (lightModeOn)
                backColor = Color.FromArgb(209, 209, 209);
            else
                backColor = Color.FromArgb(31, 31, 31);
            this.BackColor = backColor;
        }


        private void addPost_MouseHover(object sender, EventArgs e)
        {
            addPostBtn.Image.Dispose();
            addPostBtn.Image = Image.FromFile(Environment.CurrentDirectory + @"\Assets\Selected Mode\left-half-triangle.png");
        }

        private void addPost_MouseLeave(object sender, EventArgs e)
        {
            addPostBtn.Image.Dispose();
            addPostBtn.Image = Image.FromFile(UI.Return_UI_Location() + @"\left-half-triangle.png");
        }

        private void addPost_Click(object sender, EventArgs e)
        {
            panelRef.Dispose();
            AddPost addPost = new AddPost(main.userID, main.userName, lightModeOn) { TopLevel = false, TopMost = true };;
            main.formVirtualizer.Controls.Add(addPost);
            addPost.Show();
        }

        private void addStory_Click(object sender, EventArgs e)
        {
            panelRef.Dispose();
            AddStory addStory = new AddStory(main.userID, main.userName, lightModeOn) { TopLevel = false, TopMost = true };;
            main.formVirtualizer.Controls.Add(addStory);
            addStory.Show();
        }

        private void addStory_MouseHover(object sender, EventArgs e)
        {
            addStoryBtn.Image.Dispose();
            addStoryBtn.Image = Image.FromFile(Environment.CurrentDirectory + @"\Assets\Selected Mode\right-half-triangle.png");
        }

        private void addStory_MouseLeave(object sender, EventArgs e)
        {
            addStoryBtn.Image.Dispose();
            addStoryBtn.Image = Image.FromFile(UI.Return_UI_Location() + @"\right-half-triangle.png");
        }
    }
}

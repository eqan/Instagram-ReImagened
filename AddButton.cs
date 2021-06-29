using System;
using System.Drawing;
using System.Windows.Forms;

namespace Instagram
{
    public partial class AddButton : Form
    {
        UIUtilities UI;
        Main main;
        Panel panelRef;
        public AddButton(Main main)
        {
            InitializeComponent();
            this.main = main;
            UI = new UIUtilities(main.lightModeOn);
            Configure_Theme();
        }

        public void Add_Panel_Reference(Panel panel)
        {
            this.panelRef = panel;
        }

        private void Configure_Theme()
        {
            Color backColor;
            if (main.lightModeOn)
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
            if (main.lightModeOn)
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
            if(main.form != null)
            {
                main.form.Dispose();
                panelRef.Dispose();
                main.form = new AddPost(main.userID, main.userName, main.lightModeOn) { TopLevel = false, TopMost = true };;
                main.form.Show();
            }
        }

        private void addStory_Click(object sender, EventArgs e)
        {
            if(main.form != null)
            {
                main.form.Dispose();
                panelRef.Dispose();
                main.form = new AddStory(main.userID, main.userName, main.lightModeOn) { TopLevel = false, TopMost = true };;
                main.form.Show();
            }
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

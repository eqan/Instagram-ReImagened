using System;
using System.Drawing;
using System.Windows.Forms;

namespace Instagram
{
    public partial class Story : Form
    {
        UIUtilities UI;
        DBHandlingUtilities dbHandler;
        Image[] storyList;
        int storyCount = 0;
        string tableName;
        Main main;
        public Story(string tableName, Image profilePicture, Main form)
        {
            InitializeComponent();
            this.main = form;
            Initial_Setting_Initialzier(tableName, profilePicture);
            loadingIndicator.Width = 0;
        }

        private void Initial_Setting_Initialzier(string tableName, Image profilePicture)
        {
            UI = new UIUtilities(main.lightModeOn);
            Configure_Theme();
            profileBox.Bitmap = (Bitmap)profilePicture;
            this.tableName = tableName;
            this.tableName += "_StoryViewTable";
            dbHandler = new DBHandlingUtilities();
            timer1.Start();
            Load_Images();
        }

        private void Configure_Theme()
        {
            Color backColor;
            if (main.lightModeOn)
                backColor = Color.FromArgb(255, 255, 255);
            else
                backColor = Color.FromArgb(0, 0, 0);
            this.BackColor = backColor;
            storyBox.BackColor = backColor;
            nextBtn.Image = Image.FromFile(UI.Return_UI_Location() + "next.png");
            previousBtn.Image = Image.FromFile(UI.Return_UI_Location() + "back.png");
        }

        private void Load_Images()
        {
            storyList = dbHandler.Retrieve_All_Pictures(tableName);
            storyBox.Image = storyList[0];
        }

        private void story_Load(object sender, EventArgs e)
        {
            loadingIndicator.BorderStyle = BorderStyle.Fixed3D;
            loadingIndicator.BackColor = Color.DodgerBlue;
            loadingIndicator.Width = 0;
            loadingIndicator.Height = 5;
        }

        private void incrementStories()
        {
            if (storyCount < storyList.Length - 1)
            {
                storyCount++;
                storyBox.Image = storyList[storyCount];
                loadingIndicator.Width = 0;
                timer1.Interval = 100;
            }
            else
            {
                main.Show();
                this.Dispose();
            }
        }
        private void decrementStories()
        {
            if (storyCount > 0)
            {
                storyCount--;
                storyBox.Image = storyList[storyCount];
            }
            else
            {
                main.Show();
                this.Dispose();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Width > loadingIndicator.Width)
                loadingIndicator.Width += 8;
            else
                incrementStories();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            incrementStories();
        }

        private void previousBtn_Click(object sender, EventArgs e)
        {
            decrementStories();
        }

        private void previousBtn_MouseHover(object sender, EventArgs e)
        {
            previousBtn.Image.Dispose();
            previousBtn.Image = Image.FromFile(Environment.CurrentDirectory + @"\Assets\Selected Mode\back.png");
        }

        private void previousBtn_MouseLeave(object sender, EventArgs e)
        {
            previousBtn.Image.Dispose();
            previousBtn.Image = Image.FromFile(UI.Return_UI_Location() + "back.png");
        }

        private void nextBtn_MouseHover(object sender, EventArgs e)
        {
            nextBtn.Image.Dispose();
            nextBtn.Image = Image.FromFile(Environment.CurrentDirectory + @"\Assets\Selected Mode\next.png");
        }

        private void nextBtn_MouseLeave(object sender, EventArgs e)
        {
            nextBtn.Image.Dispose();
            nextBtn.Image = Image.FromFile(UI.Return_UI_Location() + "next.png");
        }
    }
}

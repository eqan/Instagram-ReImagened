using System;
using System.Drawing;
using System.Windows.Forms;

namespace Instagram
{
    public partial class Story : Form
    {
        bool lightModeOn = false;
        UIUtilities UI;
        DBHandlingUtilities dbHandler;
        Image[] storyList;
        int storyCount = 0;
        string tableName;
        Form form;
        public Story(string tableName, Image profilePicture, bool lightModeOn, Form form)
        {
            InitializeComponent();
            this.lightModeOn = lightModeOn;
            this.form = form;
            Initial_Setting_Initialzier(tableName, profilePicture);
        }

        private void Initial_Setting_Initialzier(string tableName, Image profilePicture)
        {
            UI = new UIUtilities(lightModeOn);
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
            if (lightModeOn)
                backColor = Color.FromArgb(255, 255, 255);
            else
                backColor = Color.FromArgb(0, 0, 0);
            this.BackColor = backColor;
            storyBox.BackColor = backColor;
            Initialize_Buttons(backColor);
        }

        private void Initialize_Buttons(Color backColor)
        {
            int[] btnSize = { 50, 50};
            PictureBox nextStory = UI.Create_Button("next", btnSize, new int[] { this.Width - btnSize[0] - 10, this.Height / 2 - 10 }, backColor, lightModeOn);
            nextStory.MouseClick += new MouseEventHandler((o, a) =>
            {
                incrementStories();
            }
            );
            PictureBox backStory = UI.Create_Button("back", btnSize, new int[] { 0 + 10, this.Height / 2 - 10 }, backColor, lightModeOn);
            backStory.MouseClick += new MouseEventHandler((o, a) =>
            {
                decrementStories();
            }
            );
            Controls.Add(nextStory);
            Controls.Add(backStory);
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
            }
            else
            {
                form.Show();
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
                form.Show();
                this.Dispose();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (loadingIndicator.Width != this.Width)
                loadingIndicator.Width += 8;
            else
            {
                incrementStories();
                loadingIndicator.Dispose();
                timer1.Dispose();
            }
        }

    }
}

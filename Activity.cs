using System;
using System.Windows.Forms;
using System.Drawing;

namespace Instagram
{
    public partial class Activity : Form
    {
        DBHandlingUtilities dbHandler;
        Main main;
        public Activity(Main main)
        {
            InitializeComponent();
            this.main = main;
            dbHandler = new DBHandlingUtilities();
            Configure_Theme();
            Display_Activity();
        }

        private void Configure_Theme()
        {
            Color backColor;
            if (main.lightModeOn)
                backColor = Color.FromArgb(209, 209, 209);
            else
                backColor = Color.FromArgb(31, 31, 31);
            this.BackColor = backColor;
        }

        private void Display_Activity()
        {
            ActivityRow[] activityList = dbHandler.Generate_Activity(main.userID, main.userName, main.lightModeOn);
            activityFeed.AutoScroll = true;
            if(activityList != null)
            {
                for (int i = 0; i < activityList.Length; i++)
                {
                    activityList[i].TopLevel = false;
                    activityFeed.Controls.Add(activityList[i]);
                    activityList[i].Show();
                }
            }
        }
    }
}

using System.Windows.Forms;

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
            Display_Activity();
        }

        private void Display_Activity()
        {
            ActivityRow[] activityList = dbHandler.Generate_Activity(main.userID, main.userName, main.lightModeOn);
            activityFeed.AutoScroll = true;
            for (int i = 0; i < activityList.Length; i++)
            {
                activityList[i].TopLevel = false;
                activityFeed.Controls.Add(activityList[i]);
                activityList[i].Show();
            }
        }
    }
}

using System;
using System.Windows.Forms;

namespace Instagram
{
    public partial class ActivityRow : Form
    {
        bool lightModeOn;
        string userID, userName;
        public ActivityRow(bool lightModeOn)
        {
            InitializeComponent();
            this.lightModeOn = lightModeOn;
        }
    }
}

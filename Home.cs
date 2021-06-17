using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Instagram
{
    public partial class Home : Form
    {
        bool isLightModeOn = true;
        public Home(bool isLightModeOn)
        {
            InitializeComponent();
            this.isLightModeOn = isLightModeOn;
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}

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
        DBHandlingUtilities dbHandler;
        public Home()
        {
            InitializeComponent();
            dbHandler = new DBHandlingUtilities();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
        private void Add_Post()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //dbHandler.Create_Post_Table(textBox1.Text, textBox2.Text);
            //dbHandler.Get_Picture();
            //dbHandler.Create_Post("1", "Eqan", "Hello", "Something"); }
        }
    }
}

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
    public partial class Post : Form
    {
        bool lightModeOn = true;
        UIUtilities UI;
        public Post(bool lightModeOn)
        {
            InitializeComponent();
            this.lightModeOn = lightModeOn;
            UI = new UIUtilities(this.lightModeOn);
            Configure_Theme();
        }

        private void Configure_Theme()
        {
            Color backColor, textColor;
            if (lightModeOn)
            {
                backColor = Color.FromArgb(242, 242, 242);
                textColor = Color.FromArgb(0, 0, 0);
            }
            else
            {
                backColor = Color.FromArgb(43, 43, 43);
                textColor = Color.FromArgb(255, 255, 255);
            }    
            this.BackColor = backColor;
            postDescriptionBox.BackColor = backColor;
            userNameLabel.ForeColor = backColor;
            postDescriptionBox.ForeColor = textColor;
            timeLabel.ForeColor = textColor;
            locationLabel.ForeColor = textColor;
            likeLabel.ForeColor = textColor;
        }


        private void likeBtn_MouseHover(object sender, EventArgs e)
        {
            likeBtn.Image.Dispose();
            likeBtn.Image = Image.FromFile(Environment.CurrentDirectory + @"\Assets\Selected Mode\heart.png");
        }

        private void likeBtn_MouseLeave(object sender, EventArgs e)
        {
            likeBtn.Image.Dispose();
            likeBtn.Image = Image.FromFile(UI.Return_UI_Location() + "heart.png");
        }

        private void likeBtn_Click(object sender, EventArgs e)
        {

        }

        private void bookMarkedBtn_Click(object sender, EventArgs e)
        {

        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

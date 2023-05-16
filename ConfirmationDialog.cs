using System;
using System.Windows.Forms;
using System.Drawing;

namespace Instagram
{
    public partial class ConfirmationDialog : DraggableForm
    {
        bool lightModeOn = false;

        public ConfirmationDialog(bool lightModeOn, string actionToBePerformed)
        {
            this.lightModeOn = lightModeOn;
            InitializeComponent();
            Configure_Theme();
            this.actionLabel.Text += actionToBePerformed;
        }

        private void Configure_Theme()
        {
            Color backColor, textColor;
            if (lightModeOn)
            {
                backColor = Color.FromArgb(209, 209, 209);
                textColor = Color.FromArgb(0, 0, 0);
            }
            else
            {
                backColor = Color.FromArgb(31, 31, 31);
                textColor = Color.FromArgb(255, 255, 255);
            }
            this.BackColor = backColor;
        }

        private void confirm_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.OK;
            Close();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void lbl_Name_Click(object sender, EventArgs e)
        {

        }
    }
}

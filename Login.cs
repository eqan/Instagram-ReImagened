using System;
using System.Windows.Forms;
using System.Drawing;

namespace Instagram
{
    public partial class Login : Form
    {
        DBHandlingUtilities dbHandler;
        UIUtilities UI;
        bool lightModeOn;
        Main main;
        public Login(Main main)
        {
            InitializeComponent();
            this.main = main;
            this.lightModeOn = main.lightModeOn;
            dbHandler = new DBHandlingUtilities();
            UI = new UIUtilities(lightModeOn);
            Configure_Theme();
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
            userNameLabel.BackColor = backColor;
            userNameLabel.ForeColor = textColor;
            passwordLabel.ForeColor = textColor;
            userName_Box.ForeColor = textColor;
            password_Box.ForeColor = textColor;
            userName_Box.BackColor = backColor;
            password_Box.BackColor = backColor;
            instagramLogo.BackColor = backColor;
            statusPassword.BackColor = backColor;
            statusSymbolPassword.BackColor = backColor;
            statusSymbolID.BackColor = backColor;
            statusID.BackColor = backColor;
            statusPassword.ForeColor = textColor;
            statusID.ForeColor = textColor;
            instagramLogo.Image = Image.FromFile(UI.Return_UI_Location() + "logo.png");
        }

        private void passwordBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                login();
            if (e.KeyChar == (char)Keys.Escape)
                resetEntries();
        }

        private void login()
        {
            int[] results = dbHandler.Check_UserName_And_Password(userName_Box.Text, password_Box.Text);
            if (results[0] == 1)
                setStatus(0, true, "");
            else
                setStatus(0, false, "User Name Incorrect!");
            if (results[1] == 1)
                setStatus(1, true, "");
            else
                setStatus(1, false, "Password Incorrect!");
            if (results[0] == 1 && results[1] == 1)
            {
                string userName = userName_Box.Text;
                main.form.Dispose();
                main.Initiate_Main_Form_Window(dbHandler.Return_User_ID(userName).ToString(), userName);
            }
        }
        private void resetEntries()
        {
            userName_Box.Text = "";
            password_Box.Text = "";
        }

        // ? A Utility Funtion That Display The Input Is Right/Wrong
        private void setStatus(int statusNumber, bool setStatus, string message)
        {
            string imageLocation = Environment.CurrentDirectory + @"\Assets\Generic Icons\";
            switch (statusNumber)
            {
                case 0:
                    if (setStatus)
                    {
                        statusID.Text = "";
                        statusSymbolID.ImageLocation = imageLocation + "Right" + ".png";
                    }
                    else
                    {
                        statusID.ForeColor = Color.Red;
                        statusSymbolID.ImageLocation = imageLocation + "Wrong" + ".png";
                        statusID.Text = message;
                    }
                    break;
                case 1:
                    if (setStatus)
                    {
                        statusPassword.Text = "";
                        statusSymbolPassword.ImageLocation = imageLocation + "Right" + ".png";
                    }
                    else
                    {
                        statusPassword.ForeColor = Color.Red;
                        statusSymbolPassword.ImageLocation = imageLocation + "Wrong" + ".png";
                        statusPassword.Text = message;
                    }
                    break;
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            login();
        }

        private void signUp_Click(object sender, EventArgs e)
        {
            main.form.Dispose();
            main.form = new SignUp(main){ TopLevel = false, TopMost = true };
        }
    }
}

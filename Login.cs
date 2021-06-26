using System;
using System.Windows.Forms;
using System.Drawing;

namespace Instagram
{
    public partial class Login : Form
    {
        DBHandlingUtilities dbHandler;
        bool lightModeOn;
        Main main;
        public Login(bool lightModeOn, Main main)
        {
            InitializeComponent();
            this.main = main;
            this.lightModeOn = lightModeOn;
            dbHandler = new DBHandlingUtilities();
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

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            login();
        }

        private void signUp_Btn(object sender, EventArgs e)
        {
            this.Dispose();
            SignUp signUp = new SignUp(lightModeOn, main);
            main.formVirtualizer.Controls.Add(signUp);
            signUp.Show();
        }
    }
}

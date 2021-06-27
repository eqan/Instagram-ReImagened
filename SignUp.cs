using System;
using System.Windows.Forms;
using System.Drawing;

namespace Instagram
{
    public partial class SignUp : Form
    {
        DBHandlingUtilities DBHandler;
        UIUtilities UI;
        Login loginForm;
        bool lightModeOn;
        Main main;
        public SignUp(Main main)
        {
            InitializeComponent();
            DBHandler = new DBHandlingUtilities();
            UI = new UIUtilities(this, false);
            loginForm = new Login(main);
            this.main = main;
            this.lightModeOn = main.lightModeOn;
        }

        private void signUp()
        {
            string userName = userName_Box.Text;
            string realUserName = realUserName_Box.Text;
            string pass = password_Box.Text;
            string confirmPass = confirmPassword_Box.Text;
            string tagLine = tagLine_Box.Text;
            if (checkUserName(userName))
                setStatus(0, true, "");
            else
                return;
            if (checkPassword(pass))
                setStatus(1, true, "");
            else
                return;
            if (pass == confirmPass)
            {
                setStatus(2, true, "");
                if (DBHandler.Add_User(userName, realUserName, pass, tagLine))
                {

                    Console.WriteLine("User added Successfully!");
                    setStatus(0, true, "");
                    this.Dispose();
                    loginForm.Show();
                }
                else
                    setStatus(0, false, "Account Already Present!");
            }
            else
                setStatus(2, false, "Password Doesnt Match!");
        }

        private void resetEntries()
        {
            userName_Box.Text = "";
            realUserName_Box.Text = "";
            password_Box.Text = "";
            confirmPassword_Box.Text = "";
            tagLine_Box.Text = "";
            profileBox.Image = Image.FromFile(Environment.CurrentDirectory + @"\Assets\Avatar.png");
        }
        private void logIn_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login login = new Login(main);
            main.formVirtualizer.Controls.Add(login);
            login.Show();
        }
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
                case 2:
                    if (setStatus)
                    {
                        statusConfirmPassword.Text = "";
                        statusSymbolConfirmPassword.ImageLocation = imageLocation + "Right" + ".png";
                    }
                    else
                    {
                        statusConfirmPassword.ForeColor = Color.Red;
                        statusSymbolConfirmPassword.ImageLocation = imageLocation + "Wrong" + ".png";
                        statusConfirmPassword.Text = message;
                    }
                    break;
            }
        }
        private bool checkUserName(string ID)
        {
            int countNumberOfCharacters = 0, countNumberOfIntegers = 0;
            for (int i = 0; i < ID.Length; i++)
            {
                if (ID[i] == ' ')
                {
                    setStatus(0, false, "Space Detected!");
                    return false;
                }
                if ((ID[i] >= 65 && ID[i] <= 90) || (ID[i] >= 97 && ID[i] <= 122))
                    countNumberOfCharacters++;
                if ((ID[i] >= 48 && ID[i] <= 57))
                    countNumberOfIntegers++;
            }
            if (ID.Length <= 6)
            {
                setStatus(0, false, "Length Too Small!");
                return false;
            }
            if (countNumberOfCharacters <= 3)
            {
                setStatus(0, false, "Low Number Of Characters");
                return false;
            }
            if (countNumberOfIntegers <= 2)
            {
                setStatus(0, false, "Low Number Of Integers");
                return false;
            }
            return true;
        }
        private bool checkPassword(string pass)
        {
            bool checkCapitalLetters, checkSmallLetters, checkSpecialSymbol, checkNumberOfIntegers;
            checkCapitalLetters = checkSmallLetters = checkSpecialSymbol = checkNumberOfIntegers = false;
            for (int i = 0; i < pass.Length; i++)
            {
                if (pass[i] == ' ')
                {
                    setStatus(1, false, "Space Detected!");
                    return false;
                }
                if (pass[i] >= 65 && pass[i] <= 90)
                    checkCapitalLetters = true;
                if (pass[i] >= 97 && pass[i] <= 122)
                    checkSmallLetters = true;
                if ((pass[i] >= 33 && pass[i] <= 47) || (pass[i] >= 58 && pass[i] <= 64))
                    checkSpecialSymbol = true;
                if ((pass[i] >= 48 && pass[i] <= 57))
                    checkNumberOfIntegers = true;
            }
            if (pass.Length <= 6)
            {
                setStatus(1, false, "Length Too Small!");
                return false;
            }
            if (!checkCapitalLetters)
            {
                setStatus(1, false, "No Capital Character!");
                return false;
            }
            if (!checkSmallLetters)
            {
                setStatus(1, false, "No Small Letters!");
                return false;
            }
            if (!checkSpecialSymbol)
            {
                setStatus(1, false, "No Special Symbols!");
                return false;
            }
            if (!checkNumberOfIntegers)
            {
                setStatus(1, false, "No Integers!");
                return false;
            }
            return true;
        }


        private void signUp_Click(object sender, EventArgs e)
        {
            signUp();
        }

        private void circularButton1_Click(object sender, EventArgs e)
        {
            DBHandler.Get_Picture();
            profileBox.ImageLocation = DBHandler.fileDirectory;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pictureBox2.Image.Dispose();
            pictureBox2.Image = Image.FromFile(Environment.CurrentDirectory + @"\Assets\Selected Mode\back.png");
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image.Dispose();
            pictureBox2.Image = Image.FromFile(UI.Return_UI_Location() + "back.png");
        }
    }
}

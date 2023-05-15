using System.Windows.Forms;
using System.Drawing;
using System;

namespace Instagram
{
    public partial class Search : Form
    {
        ProfilePreview[] searchResults;
        DBHandlingUtilities dbHandler;
        bool lightModeOn;
        Main main;
        public Search(Main main)
        {
            InitializeComponent();
            dbHandler = new DBHandlingUtilities();
            this.lightModeOn = main.lightModeOn;
            this.main = main;
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
            searchBox.BackColor = backColor;
            searchBox.ForeColor = textColor;
            resultFeed.BackColor = backColor;
        }


        private void Display_Posts()
        {
            resultFeed.AutoScroll = true;
            for(int i=0; i< searchResults.Length;i++)
            {
                try
                {
                    searchResults[i].TopLevel = false;
                    resultFeed.Controls.Add(searchResults[i]);
                    searchResults[i].Show();
                }
                catch(Exception error)
                {
                    Console.WriteLine(error.Message);
                }
            }
        }
        private void Search_Input(string input)
        {
            searchResults = dbHandler.Return_Search_Results(input, main);
            Display_Posts();
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                resultFeed.Controls.Clear();
                Search_Input(searchBox.Text);
            }
            if (e.KeyChar == (char)Keys.Escape)
            {
                searchBox.Text = "";
                resultFeed.Controls.Clear();
            }
        }
    }
}

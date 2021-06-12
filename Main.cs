using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Instagram
{
    public partial class Main : Form
    {
        UIUtilities UI;
        bool lightModeOn = true;
        int time = 0;
        public Main()
        {
            InitializeComponent();
            using (var stream = File.OpenRead(Environment.CurrentDirectory  + @"\Assets\Logo.ico"))
            {
                this.Icon = new Icon(stream);
            }
        }

        private void Initialize_GUI_Components()
        {
            // Top Left Buttons
            this.Controls.Add(UI.Get_CloseBtn());
            this.Controls.Add(UI.Get_MaximizeBtn());
            this.Controls.Add(UI.Get_MinimizeBtn());
            // Side Panel
            this.Controls.Add(UI.Get_Panel());
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            Start_Intro();
        }

        void Start_Intro()
        {
            string vidLocation;
            if(!lightModeOn)
            {
                vidLocation = Environment.CurrentDirectory + @"\Assets\Dark Mode\Intro.mp4";
                this.BackColor = Color.Black;
            }
            else
            {
                vidLocation = Environment.CurrentDirectory + @"\Assets\Light Mode\Intro.mp4";
                this.BackColor = Color.White;
            }
            axMoviePlayer1.FileName = vidLocation;
            axMoviePlayer1.Play();
            timer1.Interval = 900;
            timer1.Start();
        }


        // ? Count The Duration Of The Intro And Proceeds TO The Next Form After The Designated Time
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time == (int)axMoviePlayer1.Duration)
            {
                axMoviePlayer1.Stop();
                Initiate_Main_Form_Window();
            }
            time++;
        }

        private void Initiate_Main_Form_Window()
        {
            Dispose_Intro_Screen();
            this.Size = new Size(800, 450);
            this.CenterToScreen();
            UI = new UIUtilities(this, lightModeOn);
            Initialize_GUI_Components();
        }

        private void Dispose_Intro_Screen()
        {
            timer1.Stop();
            time = 0;
            axMoviePlayer1.Dispose();
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            IntPtr handle = this.Handle;
            UI.MouseDown(handle, sender, e);
        }
    }
}

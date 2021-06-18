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
        Form form;
        int time = 0;
        public Main()
        {
            InitializeComponent();
            using (var stream = File.OpenRead(Environment.CurrentDirectory + @"\Assets\Logo.ico"))
            {
                this.Icon = new Icon(stream);
            }
            formVirtualizer.Visible = false;
            form = new Home(true) { TopLevel = false, TopMost = true };
        }
        private void Initialize_GUI_Components()
        {
            // Top Left Buttons
            this.Controls.Add(UI.Get_CloseBtn());
            this.Controls.Add(UI.Get_MaximizeBtn());
            this.Controls.Add(UI.Get_MinimizeBtn());
            // Side Panel
            this.Controls.Add(UI.Get_Panel());
            // Form virtualizer
            Initialize_Form_Virtualizer_Settings();
        }
        public void Initialize_Form_Virtualizer_Settings()
        {
            formVirtualizer.Visible = true;
            Color backColor;
            if (lightModeOn)
                backColor = Color.FromArgb(0, 0, 0);
            else
                backColor = Color.FromArgb(255, 255, 255);
            formVirtualizer.Width = this.Width - UI.sidePanel.Width;
            formVirtualizer.Height = this.Height - UI.btn_Close.Height;
            formVirtualizer.Location = new System.Drawing.Point(UI.sidePanel.Width, UI.btn_Close.Height);
            formVirtualizer.BackColor = backColor;
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            Start_Intro();
        }

        void Start_Intro()
        {
            string vidLocation;
            if (!lightModeOn)
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


        public void Initialize_Form(int option)
        {
            bool executes = true;
            form.Dispose();
            switch (option)
            {
                case 0:
                    form = new Home(true) { TopLevel = false, TopMost = true };
                    break;
                case 1:
                    form = new Chat() { TopLevel = false, TopMost = true };
                    break;
                case 2:
                    form = new Search() { TopLevel = false, TopMost = true };
                    break;
                case 3:
                    break;
                case 4:
                    form = new Activity() { TopLevel = false, TopMost = true };
                    break;
                case 5:
                    form = new Profile() { TopLevel = false, TopMost = true };
                    break;
                default:
                    executes = false;
                    break;
            }
            if (executes)
                this.formVirtualizer.Paint += new System.Windows.Forms.PaintEventHandler(this.formVirtualizer_Paint);
        }

        private void formVirtualizer_Paint(object sender, PaintEventArgs e)
        {
            formVirtualizer.Controls.Add(form);
            form.Show();
        }
    }
}
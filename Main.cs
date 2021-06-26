using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace Instagram
{
    public partial class Main : Form
    {
        UIUtilities UI;
        bool lightModeOn = false;
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
            formVirtualizer.SendToBack();
            axMoviePlayer1.BringToFront();
            form = new Home(this) { TopLevel = false, TopMost = true };
        }
        private void Initialize_GUI_Components()
        {
            // Form virtualizer
            Initialize_Form_Virtualizer_Settings();
            // Top Left Buttons
            this.Controls.Add(UI.Get_CloseBtn());
            this.Controls.Add(UI.Get_MaximizeBtn());
            this.Controls.Add(UI.Get_MinimizeBtn());
            // Side Panel
            this.Controls.Add(UI.Get_Panel());
        }
        public void Initialize_Form_Virtualizer_Settings()
        {
            formVirtualizer.Visible = true;
            Color backColor, formColor;
            if (lightModeOn)
            {
                backColor = Color.FromArgb(242, 242, 242);
            }
            else
            {
                backColor = Color.FromArgb(43, 43, 43);
            }
            formVirtualizer.Width = this.Width - UI.sidePanel.Width;
            formVirtualizer.Height = this.Height;
            formVirtualizer.Location = new System.Drawing.Point(UI.sidePanel.Width, 20);
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
            if (lightModeOn)
                this.BackColor = Color.FromArgb(242, 242, 242);
            else
                this.BackColor = Color.FromArgb(43, 43, 43);
        }

        private void Dispose_Intro_Screen()
        {
            timer1.Stop();
            time = 0;
            axMoviePlayer1.Dispose();
            formVirtualizer.BringToFront();
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
                    form = new Home(this) { TopLevel = false, TopMost = true };
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

        private void axMoviePlayer1_MouseDownEvent(object sender, AxMOVIEPLAYERLib._DMoviePlayerEvents_MouseDownEvent e)
        {
            this.axMoviePlayer1.MouseDownEvent += new AxMOVIEPLAYERLib._DMoviePlayerEvents_MouseDownEventHandler(this.axMoviePlayer1_MouseDownEvent);
        }
    }
}
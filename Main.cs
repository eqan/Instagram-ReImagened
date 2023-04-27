using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;

namespace Instagram
{
    public partial class Main : Form
    {
        UIUtilities UI;
        Panel addStoryPostButtonPanel = null;
        public bool lightModeOn = false;
        public Form form;
        int time = 0;
        public string userName = "Eqan", userID = "3";
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
        }

        public void Configure_Theme()
        {
            if (lightModeOn)
                this.BackColor = Color.FromArgb(242, 242, 242);
            else
                this.BackColor = Color.FromArgb(43, 43, 43);
            UI.Dispose_UI_Components();
            UI = new UIUtilities(this, lightModeOn);
            Initialize_GUI_Components();
            Initialize_Top_Left_Buttons();
        }

        private void Initialize_GUI_Components()
        {
            // Form virtualizer
            Initialize_Form_Virtualizer_Settings();
            // Side Panel
            this.Controls.Add(UI.Get_Panel());
        }

        private void Initialize_Top_Left_Buttons()
        {
            // Top Left Buttons
            this.Controls.Add(UI.Get_CloseBtn());
            this.Controls.Add(UI.Get_MaximizeBtn());
            this.Controls.Add(UI.Get_MinimizeBtn());
        }


        public void Initialize_Form_Virtualizer_Settings()
        {
            Color backColor;
            if (lightModeOn)
                backColor = Color.FromArgb(242, 242, 242);
            else
                backColor = Color.FromArgb(43, 43, 43);
            formVirtualizer.Width = this.Width - UI.sidePanel.Width;
            formVirtualizer.Height = this.Height;
            formVirtualizer.Location = new System.Drawing.Point(UI.sidePanel.Width, 20);
            formVirtualizer.BackColor = backColor;
        }

        public void Initialize_Form_Virtualizer_For_SignUP()
        {
            Initialize_Top_Left_Buttons();
            Color backColor;
            if (lightModeOn)
                backColor = Color.FromArgb(209, 209, 209);
            else
                backColor = Color.FromArgb(31, 31, 31);
            this.CenterToScreen();
            formVirtualizer.Width = this.Width;
            formVirtualizer.Height = this.Height - 30;
            formVirtualizer.Location = new System.Drawing.Point(0, 30);
            formVirtualizer.BackColor = backColor;
            this.BackColor = backColor;
        }

        private void Intro_Load(object sender, EventArgs e)
        {
            Create_Rounded_Corners();
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
                Initiate_Login();
            }
            time++;
        }

        public void Initiate_Main_Form_Window(string userID, string userName)
        {
            this.userID = userID;
            this.userName = userName;
            if (lightModeOn)
                this.BackColor = Color.FromArgb(242, 242, 242);
            else
                this.BackColor = Color.FromArgb(43, 43, 43);
            form = new Home(this) { TopLevel = false, TopMost = true };
            Initialize_GUI_Components();
        }

        private void Initiate_Login()
        {
            Dispose_Intro_Screen();
            this.Size = new Size(800, 450);
            UI = new UIUtilities(this, lightModeOn);
            UI.Create_Rounded_Corners();
            Initialize_Form_Virtualizer_For_SignUP();
            form = new Login(this) { TopLevel = false, TopMost = true };
        }

        private void Dispose_Intro_Screen()
        {
            timer1.Stop();
            time = 0;
            axMoviePlayer1.Dispose();
            formVirtualizer.BringToFront();
            formVirtualizer.Visible = true;
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            IntPtr handle = this.Handle;
            UI.MouseDown(handle, sender, e);
        }

        private void Check_Form_Disposed()
        {
            if (form != null)
                form.Dispose();
            //if (addStoryPostButtonPanel != null)
            //    addStoryPostButtonPanel.Dispose();
        }


        public void Initialize_Form(int option)
        {
            Color backColor;
            if (lightModeOn)
                backColor = Color.FromArgb(242, 242, 242);
            else
                backColor = Color.FromArgb(43, 43, 43);
            Check_Form_Disposed();
            bool executes = true;
            switch (option)
            {
                case 0:
                    Check_Form_Disposed();
                    form = new Home(this) { TopLevel = false, TopMost = true };
                    break;
                case 1:
                    Check_Form_Disposed();
                    form = new Chat() { TopLevel = false, TopMost = true };
                    break;
                case 2:
                    Check_Form_Disposed();
                    form = new Search(lightModeOn) { TopLevel = false, TopMost = true };
                    break;
                case 3:
                    {
                        Check_Form_Disposed();
                        AddButton addBtn = new AddButton(this) { TopLevel = false, TopMost = true };
                        addStoryPostButtonPanel = UI.Create_Panel(new int[] { addBtn.Width, addBtn.Height }, new int[] { this.Height / 2 - 160, (int)Math.Round(45 * 4.5, MidpointRounding.AwayFromZero) }, Color.Transparent);
                        addBtn.Add_Panel_Reference(addStoryPostButtonPanel);
                        this.Controls.Add(addStoryPostButtonPanel);
                        addStoryPostButtonPanel.Controls.Add(addBtn);
                        addBtn.Show();
                        addStoryPostButtonPanel.BringToFront();
                        form = new Home(this) { TopLevel = false, TopMost = true };
                        break;
                    }
                case 4:
                    Check_Form_Disposed();
                    form = new Activity(this) { TopLevel = false, TopMost = true };
                    break;
                case 5:
                    if (form != null)
                        form.Dispose();
                    form = new Profile(this) { TopLevel = false, TopMost = true };
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
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
        );

        public void Create_Rounded_Corners()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
        }

    }
}
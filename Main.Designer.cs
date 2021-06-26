namespace Instagram
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.axMoviePlayer1 = new AxMOVIEPLAYERLib.AxMoviePlayer();
            this.formVirtualizer = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.axMoviePlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // axMoviePlayer1
            // 
            this.axMoviePlayer1.Enabled = true;
            this.axMoviePlayer1.Location = new System.Drawing.Point(42, -35);
            this.axMoviePlayer1.Name = "axMoviePlayer1";
            this.axMoviePlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMoviePlayer1.OcxState")));
            this.axMoviePlayer1.Size = new System.Drawing.Size(499, 437);
            this.axMoviePlayer1.TabIndex = 0;
            this.axMoviePlayer1.MouseDownEvent += new AxMOVIEPLAYERLib._DMoviePlayerEvents_MouseDownEventHandler(this.axMoviePlayer1_MouseDownEvent);
            // 
            // formVirtualizer
            // 
            this.formVirtualizer.Location = new System.Drawing.Point(42, -2);
            this.formVirtualizer.Name = "formVirtualizer";
            this.formVirtualizer.Size = new System.Drawing.Size(499, 368);
            this.formVirtualizer.TabIndex = 1;
            this.formVirtualizer.Visible = false;
            this.formVirtualizer.Paint += new System.Windows.Forms.PaintEventHandler(this.formVirtualizer_Paint);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 366);
            this.Controls.Add(this.formVirtualizer);
            this.Controls.Add(this.axMoviePlayer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Intro_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Main_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.axMoviePlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private AxMOVIEPLAYERLib.AxMoviePlayer axMoviePlayer1;
        public System.Windows.Forms.Panel formVirtualizer;
    }
}


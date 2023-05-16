namespace Instagram
{
    partial class Post
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Post));
            this.postPictureBox = new System.Windows.Forms.PictureBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.likeBtn = new System.Windows.Forms.PictureBox();
            this.likeLabel = new System.Windows.Forms.Label();
            this.postDescriptionBox = new System.Windows.Forms.RichTextBox();
            this.timeLabel = new System.Windows.Forms.Label();
            this.bookMarkedBtn = new System.Windows.Forms.PictureBox();
            this.topBar = new System.Windows.Forms.Label();
            this.bottomBar = new System.Windows.Forms.Label();
            this.profilePictureBox = new Instagram.CircularPictureBox();
            this.menuBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.postPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookMarkedBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // postPictureBox
            // 
            this.postPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.postPictureBox.Location = new System.Drawing.Point(67, 70);
            this.postPictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.postPictureBox.Name = "postPictureBox";
            this.postPictureBox.Size = new System.Drawing.Size(795, 338);
            this.postPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.postPictureBox.TabIndex = 0;
            this.postPictureBox.TabStop = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(128, 22);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(127, 20);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "User_Name123";
            this.userNameLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(128, 48);
            this.locationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(67, 18);
            this.locationLabel.TabIndex = 3;
            this.locationLabel.Text = "Location";
            // 
            // likeBtn
            // 
            this.likeBtn.AccessibleName = "Public";
            this.likeBtn.Image = ((System.Drawing.Image)(resources.GetObject("likeBtn.Image")));
            this.likeBtn.Location = new System.Drawing.Point(59, 416);
            this.likeBtn.Margin = new System.Windows.Forms.Padding(4);
            this.likeBtn.Name = "likeBtn";
            this.likeBtn.Size = new System.Drawing.Size(57, 37);
            this.likeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.likeBtn.TabIndex = 4;
            this.likeBtn.TabStop = false;
            this.likeBtn.Click += new System.EventHandler(this.likeBtn_Click);
            this.likeBtn.MouseLeave += new System.EventHandler(this.likeBtn_MouseLeave);
            this.likeBtn.MouseHover += new System.EventHandler(this.likeBtn_MouseHover);
            // 
            // likeLabel
            // 
            this.likeLabel.AccessibleName = "";
            this.likeLabel.AutoSize = true;
            this.likeLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeLabel.Location = new System.Drawing.Point(76, 460);
            this.likeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.likeLabel.Name = "likeLabel";
            this.likeLabel.Size = new System.Drawing.Size(64, 20);
            this.likeLabel.TabIndex = 5;
            this.likeLabel.Text = "0 Likes";
            // 
            // postDescriptionBox
            // 
            this.postDescriptionBox.BackColor = System.Drawing.SystemColors.Control;
            this.postDescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.postDescriptionBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.postDescriptionBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postDescriptionBox.Location = new System.Drawing.Point(59, 494);
            this.postDescriptionBox.Margin = new System.Windows.Forms.Padding(4);
            this.postDescriptionBox.Name = "postDescriptionBox";
            this.postDescriptionBox.ReadOnly = true;
            this.postDescriptionBox.Size = new System.Drawing.Size(796, 43);
            this.postDescriptionBox.TabIndex = 6;
            this.postDescriptionBox.Text = "";
            this.postDescriptionBox.TextChanged += new System.EventHandler(this.postDescriptionBox_TextChanged);
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(781, 14);
            this.timeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(89, 18);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "2 Hours Ago";
            // 
            // bookMarkedBtn
            // 
            this.bookMarkedBtn.Image = ((System.Drawing.Image)(resources.GetObject("bookMarkedBtn.Image")));
            this.bookMarkedBtn.Location = new System.Drawing.Point(797, 416);
            this.bookMarkedBtn.Margin = new System.Windows.Forms.Padding(4);
            this.bookMarkedBtn.Name = "bookMarkedBtn";
            this.bookMarkedBtn.Size = new System.Drawing.Size(57, 37);
            this.bookMarkedBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bookMarkedBtn.TabIndex = 8;
            this.bookMarkedBtn.TabStop = false;
            this.bookMarkedBtn.Click += new System.EventHandler(this.bookMarkedBtn_Click);
            this.bookMarkedBtn.MouseLeave += new System.EventHandler(this.bookMarkedBtn_MouseLeave);
            this.bookMarkedBtn.MouseHover += new System.EventHandler(this.bookMarkedBtn_MouseHover);
            // 
            // topBar
            // 
            this.topBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topBar.BackColor = System.Drawing.Color.White;
            this.topBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topBar.Location = new System.Drawing.Point(-4, -9);
            this.topBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(937, 18);
            this.topBar.TabIndex = 46;
            // 
            // bottomBar
            // 
            this.bottomBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomBar.BackColor = System.Drawing.Color.White;
            this.bottomBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bottomBar.Location = new System.Drawing.Point(-4, 544);
            this.bottomBar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.bottomBar.Name = "bottomBar";
            this.bottomBar.Size = new System.Drawing.Size(959, 22);
            this.bottomBar.TabIndex = 47;
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.profilePictureBox.Bitmap = null;
            this.profilePictureBox.BorderColor = System.Drawing.Color.DodgerBlue;
            this.profilePictureBox.BorderSize = 3;
            this.profilePictureBox.EnhancedBuffering = true;
            this.profilePictureBox.ErrorImage = null;
            this.profilePictureBox.Image = null;
            this.profilePictureBox.InitialImage = null;
            this.profilePictureBox.Location = new System.Drawing.Point(65, 12);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(4);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(51, 44);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePictureBox.TabIndex = 1;
            this.profilePictureBox.TabStop = false;
            // 
            // menuBtn
            // 
            this.menuBtn.Image = ((System.Drawing.Image)(resources.GetObject("menuBtn.Image")));
            this.menuBtn.Location = new System.Drawing.Point(832, 33);
            this.menuBtn.Margin = new System.Windows.Forms.Padding(4);
            this.menuBtn.Name = "menuBtn";
            this.menuBtn.Size = new System.Drawing.Size(31, 32);
            this.menuBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.menuBtn.TabIndex = 48;
            this.menuBtn.TabStop = false;
            this.menuBtn.Click += new System.EventHandler(this.menuBtn_Click);
            this.menuBtn.MouseLeave += new System.EventHandler(this.menuBtn_MouseLeave);
            this.menuBtn.MouseHover += new System.EventHandler(this.menuBtn_MouseHover);
            // 
            // Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 558);
            this.Controls.Add(this.menuBtn);
            this.Controls.Add(this.bottomBar);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.bookMarkedBtn);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.postDescriptionBox);
            this.Controls.Add(this.likeLabel);
            this.Controls.Add(this.likeBtn);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.profilePictureBox);
            this.Controls.Add(this.postPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Post";
            this.Padding = new System.Windows.Forms.Padding(4);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.postPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookMarkedBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.menuBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox likeBtn;
        public System.Windows.Forms.PictureBox postPictureBox;
        public CircularPictureBox profilePictureBox;
        public System.Windows.Forms.Label userNameLabel;
        public System.Windows.Forms.Label locationLabel;
        public System.Windows.Forms.Label likeLabel;
        public System.Windows.Forms.RichTextBox postDescriptionBox;
        public System.Windows.Forms.Label timeLabel;
        public System.Windows.Forms.PictureBox bookMarkedBtn;
        private System.Windows.Forms.Label topBar;
        private System.Windows.Forms.Label bottomBar;
        public System.Windows.Forms.PictureBox menuBtn;
    }
}
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
            this.profilePictureBox = new Instagram.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.postPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.likeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookMarkedBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // postPictureBox
            // 
            this.postPictureBox.Location = new System.Drawing.Point(0, 46);
            this.postPictureBox.Name = "postPictureBox";
            this.postPictureBox.Size = new System.Drawing.Size(328, 201);
            this.postPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.postPictureBox.TabIndex = 0;
            this.postPictureBox.TabStop = false;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(44, 9);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(96, 15);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "User_Name123";
            this.userNameLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // locationLabel
            // 
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.Location = new System.Drawing.Point(44, 30);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(54, 14);
            this.locationLabel.TabIndex = 3;
            this.locationLabel.Text = "Location";
            // 
            // likeBtn
            // 
            this.likeBtn.AccessibleName = "Public";
            this.likeBtn.Image = ((System.Drawing.Image)(resources.GetObject("likeBtn.Image")));
            this.likeBtn.Location = new System.Drawing.Point(0, 253);
            this.likeBtn.Name = "likeBtn";
            this.likeBtn.Size = new System.Drawing.Size(43, 30);
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
            this.likeLabel.Location = new System.Drawing.Point(5, 286);
            this.likeLabel.Name = "likeLabel";
            this.likeLabel.Size = new System.Drawing.Size(38, 15);
            this.likeLabel.TabIndex = 5;
            this.likeLabel.Text = "Likes";
            // 
            // postDescriptionBox
            // 
            this.postDescriptionBox.BackColor = System.Drawing.SystemColors.Control;
            this.postDescriptionBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.postDescriptionBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postDescriptionBox.Location = new System.Drawing.Point(0, 304);
            this.postDescriptionBox.Name = "postDescriptionBox";
            this.postDescriptionBox.Size = new System.Drawing.Size(328, 47);
            this.postDescriptionBox.TabIndex = 6;
            this.postDescriptionBox.Text = "";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(255, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(73, 14);
            this.timeLabel.TabIndex = 7;
            this.timeLabel.Text = "2 Hours Ago";
            // 
            // bookMarkedBtn
            // 
            this.bookMarkedBtn.Image = ((System.Drawing.Image)(resources.GetObject("bookMarkedBtn.Image")));
            this.bookMarkedBtn.Location = new System.Drawing.Point(285, 253);
            this.bookMarkedBtn.Name = "bookMarkedBtn";
            this.bookMarkedBtn.Size = new System.Drawing.Size(43, 30);
            this.bookMarkedBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bookMarkedBtn.TabIndex = 8;
            this.bookMarkedBtn.TabStop = false;
            this.bookMarkedBtn.Click += new System.EventHandler(this.bookMarkedBtn_Click);
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
            this.profilePictureBox.Location = new System.Drawing.Point(0, 4);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(38, 36);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 1;
            this.profilePictureBox.TabStop = false;
            // 
            // Post
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 351);
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
            this.Name = "Post";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.postPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.likeBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookMarkedBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
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
    }
}
﻿namespace Instagram
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.userNameLabel = new System.Windows.Forms.Label();
            this.realUserNameLabel = new System.Windows.Forms.Label();
            this.postFeed = new System.Windows.Forms.ListView();
            this.postIndicatorLabel = new System.Windows.Forms.Label();
            this.postCountLabel = new System.Windows.Forms.Label();
            this.followersCountLabel = new System.Windows.Forms.Label();
            this.followersIndicatorLabel = new System.Windows.Forms.Label();
            this.followingCountLabel = new System.Windows.Forms.Label();
            this.followingIndicatorLabel = new System.Windows.Forms.Label();
            this.taglineBox = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.gridViewBtn = new System.Windows.Forms.Button();
            this.streamViewBtn = new System.Windows.Forms.Button();
            this.bookMarkBtn = new System.Windows.Forms.Button();
            this.themeBtn = new Instagram.CustomButton();
            this.editProfileBtn = new Instagram.CustomButton();
            this.profilePictureBox = new Instagram.CircularPictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.userNameLabel.Location = new System.Drawing.Point(147, 25);
            this.userNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(88, 33);
            this.userNameLabel.TabIndex = 51;
            this.userNameLabel.Text = "label1";
            // 
            // realUserNameLabel
            // 
            this.realUserNameLabel.AutoSize = true;
            this.realUserNameLabel.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.realUserNameLabel.Location = new System.Drawing.Point(149, 64);
            this.realUserNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.realUserNameLabel.Name = "realUserNameLabel";
            this.realUserNameLabel.Size = new System.Drawing.Size(62, 23);
            this.realUserNameLabel.TabIndex = 52;
            this.realUserNameLabel.Text = "label2";
            // 
            // postFeed
            // 
            this.postFeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.postFeed.HideSelection = false;
            this.postFeed.Location = new System.Drawing.Point(27, 266);
            this.postFeed.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.postFeed.Name = "postFeed";
            this.postFeed.Size = new System.Drawing.Size(929, 287);
            this.postFeed.TabIndex = 53;
            this.postFeed.UseCompatibleStateImageBehavior = false;
            this.postFeed.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_AfterLabelEdit);
            this.postFeed.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // postIndicatorLabel
            // 
            this.postIndicatorLabel.AutoSize = true;
            this.postIndicatorLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postIndicatorLabel.ForeColor = System.Drawing.Color.Black;
            this.postIndicatorLabel.Location = new System.Drawing.Point(389, 59);
            this.postIndicatorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.postIndicatorLabel.Name = "postIndicatorLabel";
            this.postIndicatorLabel.Size = new System.Drawing.Size(61, 24);
            this.postIndicatorLabel.TabIndex = 54;
            this.postIndicatorLabel.Text = "Posts";
            // 
            // postCountLabel
            // 
            this.postCountLabel.AutoSize = true;
            this.postCountLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postCountLabel.Location = new System.Drawing.Point(405, 27);
            this.postCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.postCountLabel.Name = "postCountLabel";
            this.postCountLabel.Size = new System.Drawing.Size(30, 33);
            this.postCountLabel.TabIndex = 55;
            this.postCountLabel.Text = "0";
            // 
            // followersCountLabel
            // 
            this.followersCountLabel.AutoSize = true;
            this.followersCountLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followersCountLabel.Location = new System.Drawing.Point(595, 28);
            this.followersCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.followersCountLabel.Name = "followersCountLabel";
            this.followersCountLabel.Size = new System.Drawing.Size(30, 33);
            this.followersCountLabel.TabIndex = 57;
            this.followersCountLabel.Text = "0";
            // 
            // followersIndicatorLabel
            // 
            this.followersIndicatorLabel.AutoSize = true;
            this.followersIndicatorLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followersIndicatorLabel.ForeColor = System.Drawing.Color.Black;
            this.followersIndicatorLabel.Location = new System.Drawing.Point(563, 59);
            this.followersIndicatorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.followersIndicatorLabel.Name = "followersIndicatorLabel";
            this.followersIndicatorLabel.Size = new System.Drawing.Size(96, 24);
            this.followersIndicatorLabel.TabIndex = 56;
            this.followersIndicatorLabel.Text = "Followers";
            // 
            // followingCountLabel
            // 
            this.followingCountLabel.AutoSize = true;
            this.followingCountLabel.Font = new System.Drawing.Font("Roboto", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followingCountLabel.Location = new System.Drawing.Point(787, 27);
            this.followingCountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.followingCountLabel.Name = "followingCountLabel";
            this.followingCountLabel.Size = new System.Drawing.Size(30, 33);
            this.followingCountLabel.TabIndex = 59;
            this.followingCountLabel.Text = "0";
            // 
            // followingIndicatorLabel
            // 
            this.followingIndicatorLabel.AutoSize = true;
            this.followingIndicatorLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.followingIndicatorLabel.ForeColor = System.Drawing.Color.Black;
            this.followingIndicatorLabel.Location = new System.Drawing.Point(745, 59);
            this.followingIndicatorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.followingIndicatorLabel.Name = "followingIndicatorLabel";
            this.followingIndicatorLabel.Size = new System.Drawing.Size(95, 24);
            this.followingIndicatorLabel.TabIndex = 58;
            this.followingIndicatorLabel.Text = "Following";
            // 
            // taglineBox
            // 
            this.taglineBox.BackColor = System.Drawing.SystemColors.Control;
            this.taglineBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.taglineBox.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taglineBox.Location = new System.Drawing.Point(153, 146);
            this.taglineBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.taglineBox.Name = "taglineBox";
            this.taglineBox.Size = new System.Drawing.Size(693, 52);
            this.taglineBox.TabIndex = 60;
            this.taglineBox.Text = "Something would written here";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.gridViewBtn);
            this.flowLayoutPanel1.Controls.Add(this.streamViewBtn);
            this.flowLayoutPanel1.Controls.Add(this.bookMarkBtn);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(27, 206);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(940, 52);
            this.flowLayoutPanel1.TabIndex = 63;
            // 
            // gridViewBtn
            // 
            this.gridViewBtn.FlatAppearance.BorderSize = 0;
            this.gridViewBtn.Image = ((System.Drawing.Image)(resources.GetObject("gridViewBtn.Image")));
            this.gridViewBtn.Location = new System.Drawing.Point(4, 4);
            this.gridViewBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridViewBtn.Name = "gridViewBtn";
            this.gridViewBtn.Size = new System.Drawing.Size(327, 48);
            this.gridViewBtn.TabIndex = 0;
            this.gridViewBtn.UseVisualStyleBackColor = true;
            // 
            // streamViewBtn
            // 
            this.streamViewBtn.FlatAppearance.BorderSize = 0;
            this.streamViewBtn.Image = ((System.Drawing.Image)(resources.GetObject("streamViewBtn.Image")));
            this.streamViewBtn.Location = new System.Drawing.Point(339, 4);
            this.streamViewBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.streamViewBtn.Name = "streamViewBtn";
            this.streamViewBtn.Size = new System.Drawing.Size(333, 48);
            this.streamViewBtn.TabIndex = 1;
            this.streamViewBtn.UseVisualStyleBackColor = true;
            // 
            // bookMarkBtn
            // 
            this.bookMarkBtn.FlatAppearance.BorderSize = 0;
            this.bookMarkBtn.Image = ((System.Drawing.Image)(resources.GetObject("bookMarkBtn.Image")));
            this.bookMarkBtn.Location = new System.Drawing.Point(680, 4);
            this.bookMarkBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookMarkBtn.Name = "bookMarkBtn";
            this.bookMarkBtn.Size = new System.Drawing.Size(249, 48);
            this.bookMarkBtn.TabIndex = 2;
            this.bookMarkBtn.UseVisualStyleBackColor = true;
            // 
            // themeBtn
            // 
            this.themeBtn.BackColor = System.Drawing.Color.DimGray;
            this.themeBtn.BackgroundColor = System.Drawing.Color.DimGray;
            this.themeBtn.BorderColor = System.Drawing.Color.DodgerBlue;
            this.themeBtn.BorderRadius = 10;
            this.themeBtn.BorderSize = 0;
            this.themeBtn.FlatAppearance.BorderSize = 0;
            this.themeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themeBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeBtn.ForeColor = System.Drawing.Color.White;
            this.themeBtn.Image = ((System.Drawing.Image)(resources.GetObject("themeBtn.Image")));
            this.themeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.themeBtn.Location = new System.Drawing.Point(395, 90);
            this.themeBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.themeBtn.Name = "themeBtn";
            this.themeBtn.Size = new System.Drawing.Size(165, 49);
            this.themeBtn.TabIndex = 62;
            this.themeBtn.Text = "Dark Mode";
            this.themeBtn.TextColor = System.Drawing.Color.White;
            this.themeBtn.UseVisualStyleBackColor = false;
            this.themeBtn.Click += new System.EventHandler(this.customButton1_Click);
            // 
            // editProfileBtn
            // 
            this.editProfileBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.editProfileBtn.BackgroundColor = System.Drawing.Color.DodgerBlue;
            this.editProfileBtn.BorderColor = System.Drawing.Color.DodgerBlue;
            this.editProfileBtn.BorderRadius = 10;
            this.editProfileBtn.BorderSize = 0;
            this.editProfileBtn.FlatAppearance.BorderSize = 0;
            this.editProfileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProfileBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editProfileBtn.ForeColor = System.Drawing.Color.White;
            this.editProfileBtn.Location = new System.Drawing.Point(568, 90);
            this.editProfileBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.editProfileBtn.Name = "editProfileBtn";
            this.editProfileBtn.Size = new System.Drawing.Size(281, 49);
            this.editProfileBtn.TabIndex = 61;
            this.editProfileBtn.Text = "Edit Profile";
            this.editProfileBtn.TextColor = System.Drawing.Color.White;
            this.editProfileBtn.UseVisualStyleBackColor = false;
            this.editProfileBtn.Click += new System.EventHandler(this.editProfile_Click);
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
            this.profilePictureBox.Location = new System.Drawing.Point(27, 15);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(107, 98);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 0;
            this.profilePictureBox.TabStop = false;
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 554);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.themeBtn);
            this.Controls.Add(this.editProfileBtn);
            this.Controls.Add(this.taglineBox);
            this.Controls.Add(this.followingCountLabel);
            this.Controls.Add(this.followingIndicatorLabel);
            this.Controls.Add(this.followersCountLabel);
            this.Controls.Add(this.followersIndicatorLabel);
            this.Controls.Add(this.postCountLabel);
            this.Controls.Add(this.postIndicatorLabel);
            this.Controls.Add(this.postFeed);
            this.Controls.Add(this.realUserNameLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.profilePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Profile";
            this.Text = "Profile";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircularPictureBox profilePictureBox;
        public System.Windows.Forms.Label userNameLabel;
        public System.Windows.Forms.Label realUserNameLabel;
        private System.Windows.Forms.ListView postFeed;
        public System.Windows.Forms.Label postIndicatorLabel;
        public System.Windows.Forms.Label postCountLabel;
        public System.Windows.Forms.Label followersCountLabel;
        public System.Windows.Forms.Label followersIndicatorLabel;
        public System.Windows.Forms.Label followingCountLabel;
        public System.Windows.Forms.Label followingIndicatorLabel;
        private System.Windows.Forms.RichTextBox taglineBox;
        private CustomButton editProfileBtn;
        private CustomButton themeBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button gridViewBtn;
        private System.Windows.Forms.Button streamViewBtn;
        private System.Windows.Forms.Button bookMarkBtn;
    }
}
namespace Instagram
{
    partial class ActivityRow
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
            this.bottomBar = new System.Windows.Forms.Label();
            this.topBar = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.postPicture = new System.Windows.Forms.PictureBox();
            this.activityLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.profilePictureBox = new Instagram.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.postPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // bottomBar
            // 
            this.bottomBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomBar.BackColor = System.Drawing.Color.White;
            this.bottomBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bottomBar.Location = new System.Drawing.Point(-10, 77);
            this.bottomBar.Name = "bottomBar";
            this.bottomBar.Size = new System.Drawing.Size(637, 10);
            this.bottomBar.TabIndex = 53;
            // 
            // topBar
            // 
            this.topBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.topBar.BackColor = System.Drawing.Color.White;
            this.topBar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.topBar.Location = new System.Drawing.Point(-10, -2);
            this.topBar.Name = "topBar";
            this.topBar.Size = new System.Drawing.Size(637, 10);
            this.topBar.TabIndex = 52;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.userNameLabel.Location = new System.Drawing.Point(64, 36);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(53, 19);
            this.userNameLabel.TabIndex = 50;
            this.userNameLabel.Text = "label1";
            // 
            // postPicture
            // 
            this.postPicture.Location = new System.Drawing.Point(429, 11);
            this.postPicture.Name = "postPicture";
            this.postPicture.Size = new System.Drawing.Size(72, 62);
            this.postPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.postPicture.TabIndex = 54;
            this.postPicture.TabStop = false;
            // 
            // activityLabel
            // 
            this.activityLabel.AutoSize = true;
            this.activityLabel.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activityLabel.Location = new System.Drawing.Point(123, 37);
            this.activityLabel.Name = "activityLabel";
            this.activityLabel.Size = new System.Drawing.Size(115, 18);
            this.activityLabel.TabIndex = 56;
            this.activityLabel.Text = "Activity Mesage";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(532, 12);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(73, 14);
            this.timeLabel.TabIndex = 57;
            this.timeLabel.Text = "0 Hours Ago";
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
            this.profilePictureBox.Location = new System.Drawing.Point(16, 20);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(42, 45);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePictureBox.TabIndex = 49;
            this.profilePictureBox.TabStop = false;
            // 
            // ActivityRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 86);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.activityLabel);
            this.Controls.Add(this.postPicture);
            this.Controls.Add(this.bottomBar);
            this.Controls.Add(this.topBar);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.profilePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActivityRow";
            this.Text = "ActivityRow";
            ((System.ComponentModel.ISupportInitialize)(this.postPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bottomBar;
        private System.Windows.Forms.Label topBar;
        public System.Windows.Forms.Label userNameLabel;
        public CircularPictureBox profilePictureBox;
        public System.Windows.Forms.Label activityLabel;
        public System.Windows.Forms.Label timeLabel;
        public System.Windows.Forms.PictureBox postPicture;
    }
}
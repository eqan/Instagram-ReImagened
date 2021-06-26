namespace Instagram
{
    partial class AddPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPost));
            this.userNameLabel = new System.Windows.Forms.Label();
            this.postPictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.locationBox = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.postDescritpionBox = new System.Windows.Forms.TextBox();
            this.postDescritpionLabel = new System.Windows.Forms.Label();
            this.nextBtn = new System.Windows.Forms.PictureBox();
            this.uploadPictureBtn = new Instagram.CircularButton();
            this.profilePictureBox = new Instagram.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.postPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLabel.Location = new System.Drawing.Point(107, 30);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(96, 15);
            this.userNameLabel.TabIndex = 10;
            this.userNameLabel.Text = "User_Name123";
            // 
            // postPictureBox
            // 
            this.postPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.postPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("postPictureBox.Image")));
            this.postPictureBox.Location = new System.Drawing.Point(110, 91);
            this.postPictureBox.Name = "postPictureBox";
            this.postPictureBox.Size = new System.Drawing.Size(549, 213);
            this.postPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.postPictureBox.TabIndex = 67;
            this.postPictureBox.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(319, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 3);
            this.label5.TabIndex = 74;
            // 
            // locationBox
            // 
            this.locationBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationBox.BackColor = System.Drawing.SystemColors.Control;
            this.locationBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.locationBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationBox.ForeColor = System.Drawing.Color.Black;
            this.locationBox.Location = new System.Drawing.Point(319, 358);
            this.locationBox.Name = "locationBox";
            this.locationBox.Size = new System.Drawing.Size(242, 15);
            this.locationBox.TabIndex = 73;
            // 
            // locationLabel
            // 
            this.locationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.locationLabel.AutoSize = true;
            this.locationLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.locationLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.ForeColor = System.Drawing.Color.Black;
            this.locationLabel.Location = new System.Drawing.Point(213, 358);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(100, 28);
            this.locationLabel.TabIndex = 72;
            this.locationLabel.Text = "Location: ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(319, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 3);
            this.label1.TabIndex = 71;
            // 
            // postDescritpionBox
            // 
            this.postDescritpionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.postDescritpionBox.BackColor = System.Drawing.SystemColors.Control;
            this.postDescritpionBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.postDescritpionBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postDescritpionBox.ForeColor = System.Drawing.Color.Black;
            this.postDescritpionBox.Location = new System.Drawing.Point(319, 311);
            this.postDescritpionBox.Name = "postDescritpionBox";
            this.postDescritpionBox.Size = new System.Drawing.Size(242, 15);
            this.postDescritpionBox.TabIndex = 70;
            // 
            // postDescritpionLabel
            // 
            this.postDescritpionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.postDescritpionLabel.AutoSize = true;
            this.postDescritpionLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.postDescritpionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postDescritpionLabel.ForeColor = System.Drawing.Color.Black;
            this.postDescritpionLabel.Location = new System.Drawing.Point(142, 307);
            this.postDescritpionLabel.Name = "postDescritpionLabel";
            this.postDescritpionLabel.Size = new System.Drawing.Size(171, 28);
            this.postDescritpionLabel.TabIndex = 69;
            this.postDescritpionLabel.Text = "Post Description: ";
            // 
            // nextBtn
            // 
            this.nextBtn.Image = ((System.Drawing.Image)(resources.GetObject("nextBtn.Image")));
            this.nextBtn.Location = new System.Drawing.Point(656, 348);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(71, 69);
            this.nextBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.nextBtn.TabIndex = 75;
            this.nextBtn.TabStop = false;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            this.nextBtn.MouseLeave += new System.EventHandler(this.nextBtn_MouseLeave);
            this.nextBtn.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // uploadPictureBtn
            // 
            this.uploadPictureBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.uploadPictureBtn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.uploadPictureBtn.FlatAppearance.BorderSize = 2;
            this.uploadPictureBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DodgerBlue;
            this.uploadPictureBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.uploadPictureBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadPictureBtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.uploadPictureBtn.Image = ((System.Drawing.Image)(resources.GetObject("uploadPictureBtn.Image")));
            this.uploadPictureBtn.Location = new System.Drawing.Point(586, 245);
            this.uploadPictureBtn.Name = "uploadPictureBtn";
            this.uploadPictureBtn.Size = new System.Drawing.Size(54, 49);
            this.uploadPictureBtn.TabIndex = 68;
            this.uploadPictureBtn.UseVisualStyleBackColor = false;
            this.uploadPictureBtn.Click += new System.EventHandler(this.uploadPictureBtn_Click);
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
            this.profilePictureBox.Location = new System.Drawing.Point(60, 22);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(38, 36);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePictureBox.TabIndex = 9;
            this.profilePictureBox.TabStop = false;
            // 
            // AddPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 450);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.uploadPictureBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.locationBox);
            this.Controls.Add(this.locationLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.postDescritpionBox);
            this.Controls.Add(this.postDescritpionLabel);
            this.Controls.Add(this.postPictureBox);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.profilePictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPost";
            this.Text = "AddPost";
            ((System.ComponentModel.ISupportInitialize)(this.postPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label userNameLabel;
        public CircularPictureBox profilePictureBox;
        private CircularButton uploadPictureBtn;
        private System.Windows.Forms.PictureBox postPictureBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox locationBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox postDescritpionBox;
        private System.Windows.Forms.Label postDescritpionLabel;
        private System.Windows.Forms.PictureBox nextBtn;
    }
}
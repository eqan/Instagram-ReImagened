namespace Instagram
{
    partial class AddStory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStory));
            this.storyBox = new System.Windows.Forms.PictureBox();
            this.uploadBtn = new Instagram.CircularButton();
            this.albumBtn = new Instagram.CircularButton();
            ((System.ComponentModel.ISupportInitialize)(this.storyBox)).BeginInit();
            this.SuspendLayout();
            // 
            // storyBox
            // 
            this.storyBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.storyBox.Location = new System.Drawing.Point(1, 12);
            this.storyBox.Name = "storyBox";
            this.storyBox.Size = new System.Drawing.Size(712, 299);
            this.storyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.storyBox.TabIndex = 0;
            this.storyBox.TabStop = false;
            // 
            // uploadBtn
            // 
            this.uploadBtn.BackColor = System.Drawing.Color.DodgerBlue;
            this.uploadBtn.FlatAppearance.BorderSize = 0;
            this.uploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.uploadBtn.Image = ((System.Drawing.Image)(resources.GetObject("uploadBtn.Image")));
            this.uploadBtn.Location = new System.Drawing.Point(370, 331);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(72, 75);
            this.uploadBtn.TabIndex = 2;
            this.uploadBtn.UseVisualStyleBackColor = false;
            this.uploadBtn.Click += new System.EventHandler(this.upload_Click);
            // 
            // albumBtn
            // 
            this.albumBtn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.albumBtn.FlatAppearance.BorderSize = 0;
            this.albumBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.albumBtn.Image = ((System.Drawing.Image)(resources.GetObject("albumBtn.Image")));
            this.albumBtn.Location = new System.Drawing.Point(291, 350);
            this.albumBtn.Name = "albumBtn";
            this.albumBtn.Size = new System.Drawing.Size(55, 56);
            this.albumBtn.TabIndex = 1;
            this.albumBtn.UseVisualStyleBackColor = false;
            this.albumBtn.Click += new System.EventHandler(this.album_Click);
            // 
            // AddStory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 430);
            this.Controls.Add(this.uploadBtn);
            this.Controls.Add(this.albumBtn);
            this.Controls.Add(this.storyBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddStory";
            this.Text = "Form1";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.storyBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox storyBox;
        private CircularButton albumBtn;
        private CircularButton uploadBtn;
    }
}
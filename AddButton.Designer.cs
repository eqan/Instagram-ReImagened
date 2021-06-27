namespace Instagram
{
    partial class AddButton
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddButton));
            this.addStoryBtn = new System.Windows.Forms.PictureBox();
            this.addPostBtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.addStoryBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPostBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.addStoryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addStoryBtn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.addStoryBtn.InitialImage = null;
            this.addStoryBtn.Location = new System.Drawing.Point(-6, 45);
            this.addStoryBtn.Name = "pictureBox2";
            this.addStoryBtn.Size = new System.Drawing.Size(70, 46);
            this.addStoryBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addStoryBtn.TabIndex = 1;
            this.addStoryBtn.TabStop = false;
            this.addStoryBtn.Click += new System.EventHandler(this.addStory_Click);
            this.addStoryBtn.MouseLeave += new System.EventHandler(this.addStory_MouseLeave);
            this.addStoryBtn.MouseHover += new System.EventHandler(this.addStory_MouseHover);
            // 
            // pictureBox3
            // 
            this.addPostBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addPostBtn.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.addPostBtn.InitialImage = null;
            this.addPostBtn.Location = new System.Drawing.Point(-6, 3);
            this.addPostBtn.Name = "pictureBox3";
            this.addPostBtn.Size = new System.Drawing.Size(70, 44);
            this.addPostBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addPostBtn.TabIndex = 2;
            this.addPostBtn.TabStop = false;
            this.addPostBtn.Click += new System.EventHandler(this.addStory_Click);
            this.addPostBtn.MouseLeave += new System.EventHandler(this.addPost_MouseLeave);
            this.addPostBtn.MouseHover += new System.EventHandler(this.addPost_MouseHover);
            // 
            // AddButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(66, 92);
            this.Controls.Add(this.addPostBtn);
            this.Controls.Add(this.addStoryBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddButton";
            this.Text = "UploadPost";
            ((System.ComponentModel.ISupportInitialize)(this.addStoryBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addPostBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox addStoryBtn;
        private System.Windows.Forms.PictureBox addPostBtn;
    }
}
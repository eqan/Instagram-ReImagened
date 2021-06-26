namespace Instagram
{
    partial class Story
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Story));
            this.storyBox = new System.Windows.Forms.PictureBox();
            this.loadingIndicator = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.profileBox = new Instagram.CircularPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.storyBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBox)).BeginInit();
            this.SuspendLayout();
            // 
            // storyBox
            // 
            this.storyBox.BackColor = System.Drawing.Color.Black;
            this.storyBox.Location = new System.Drawing.Point(66, 86);
            this.storyBox.Name = "storyBox";
            this.storyBox.Size = new System.Drawing.Size(623, 285);
            this.storyBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.storyBox.TabIndex = 0;
            this.storyBox.TabStop = false;
            // 
            // loadingIndicator
            // 
            this.loadingIndicator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingIndicator.BackColor = System.Drawing.Color.DodgerBlue;
            this.loadingIndicator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loadingIndicator.Location = new System.Drawing.Point(1, 422);
            this.loadingIndicator.Name = "loadingIndicator";
            this.loadingIndicator.Size = new System.Drawing.Size(0, 3);
            this.loadingIndicator.TabIndex = 75;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // profileBox
            // 
            this.profileBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.profileBox.Bitmap = ((System.Drawing.Bitmap)(resources.GetObject("profileBox.Bitmap")));
            this.profileBox.BorderColor = System.Drawing.Color.DodgerBlue;
            this.profileBox.BorderSize = 3;
            this.profileBox.EnhancedBuffering = true;
            this.profileBox.ErrorImage = null;
            this.profileBox.Image = null;
            this.profileBox.InitialImage = null;
            this.profileBox.Location = new System.Drawing.Point(12, 12);
            this.profileBox.Name = "profileBox";
            this.profileBox.Size = new System.Drawing.Size(56, 54);
            this.profileBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profileBox.TabIndex = 76;
            this.profileBox.TabStop = false;
            // 
            // Story
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(742, 426);
            this.Controls.Add(this.profileBox);
            this.Controls.Add(this.loadingIndicator);
            this.Controls.Add(this.storyBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Story";
            this.Text = "Story";
            this.Load += new System.EventHandler(this.story_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storyBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox storyBox;
        private System.Windows.Forms.Label loadingIndicator;
        private System.Windows.Forms.Timer timer1;
        private CircularPictureBox profileBox;
    }
}
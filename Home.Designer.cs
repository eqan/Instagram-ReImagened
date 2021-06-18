namespace Instagram
{
    partial class Home
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
            this.feedPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.storiesFeed = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // feedPanel
            // 
            this.feedPanel.Location = new System.Drawing.Point(0, 93);
            this.feedPanel.Name = "feedPanel";
            this.feedPanel.Size = new System.Drawing.Size(800, 358);
            this.feedPanel.TabIndex = 0;
            // 
            // storiesFeed
            // 
            this.storiesFeed.Location = new System.Drawing.Point(0, -1);
            this.storiesFeed.Name = "storiesFeed";
            this.storiesFeed.Size = new System.Drawing.Size(800, 88);
            this.storiesFeed.TabIndex = 1;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.storiesFeed);
            this.Controls.Add(this.feedPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel feedPanel;
        private System.Windows.Forms.FlowLayoutPanel storiesFeed;
    }
}
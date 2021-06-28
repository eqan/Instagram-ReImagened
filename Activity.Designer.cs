namespace Instagram
{
    partial class Activity
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
            this.activityFeed = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // activityFeed
            // 
            this.activityFeed.Location = new System.Drawing.Point(54, 0);
            this.activityFeed.Name = "activityFeed";
            this.activityFeed.Size = new System.Drawing.Size(706, 450);
            this.activityFeed.TabIndex = 0;
            // 
            // Activity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 450);
            this.Controls.Add(this.activityFeed);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Activity";
            this.Text = "Activity";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel activityFeed;
    }
}
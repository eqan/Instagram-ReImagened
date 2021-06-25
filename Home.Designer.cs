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
            this.storyListView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // feedPanel
            // 
            this.feedPanel.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.feedPanel.Location = new System.Drawing.Point(37, 75);
            this.feedPanel.Name = "feedPanel";
            this.feedPanel.Size = new System.Drawing.Size(698, 376);
            this.feedPanel.TabIndex = 0;
            this.feedPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.feedPanel_Paint);
            // 
            // storyListView
            // 
            this.storyListView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.storyListView.BackColor = System.Drawing.Color.White;
            this.storyListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.storyListView.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storyListView.ForeColor = System.Drawing.Color.DodgerBlue;
            this.storyListView.HideSelection = false;
            this.storyListView.Location = new System.Drawing.Point(-2, 0);
            this.storyListView.Name = "storyListView";
            this.storyListView.Size = new System.Drawing.Size(801, 78);
            this.storyListView.TabIndex = 2;
            this.storyListView.UseCompatibleStateImageBehavior = false;
            this.storyListView.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.listView1_AfterLabelEdit);
            this.storyListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.storyListView);
            this.Controls.Add(this.feedPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView storyListView;
        public System.Windows.Forms.FlowLayoutPanel feedPanel;
        private System.Windows.Forms.Button button1;
    }
}
namespace Instagram
{
    partial class ConfirmationDialog
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
            this.customButton1 = new Instagram.CustomButton();
            this.customButton2 = new Instagram.CustomButton();
            this.actionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Crimson;
            this.customButton1.BackgroundColor = System.Drawing.Color.Crimson;
            this.customButton1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.customButton1.BorderRadius = 10;
            this.customButton1.BorderSize = 0;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.ForeColor = System.Drawing.Color.White;
            this.customButton1.Location = new System.Drawing.Point(108, 132);
            this.customButton1.Margin = new System.Windows.Forms.Padding(4);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(157, 59);
            this.customButton1.TabIndex = 90;
            this.customButton1.Text = "Cancel";
            this.customButton1.TextColor = System.Drawing.Color.White;
            this.customButton1.UseVisualStyleBackColor = false;
            this.customButton1.Click += new System.EventHandler(this.cancel_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.SpringGreen;
            this.customButton2.BackgroundColor = System.Drawing.Color.SpringGreen;
            this.customButton2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.customButton2.BorderRadius = 10;
            this.customButton2.BorderSize = 0;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton2.ForeColor = System.Drawing.Color.White;
            this.customButton2.Location = new System.Drawing.Point(313, 132);
            this.customButton2.Margin = new System.Windows.Forms.Padding(4);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(157, 59);
            this.customButton2.TabIndex = 89;
            this.customButton2.Text = "Confirm";
            this.customButton2.TextColor = System.Drawing.Color.White;
            this.customButton2.UseVisualStyleBackColor = false;
            this.customButton2.Click += new System.EventHandler(this.confirm_Click);
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actionLabel.ForeColor = System.Drawing.Color.White;
            this.actionLabel.Location = new System.Drawing.Point(48, 67);
            this.actionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(297, 32);
            this.actionLabel.TabIndex = 99;
            this.actionLabel.Text = "Are you sure you want to ";
            this.actionLabel.Click += new System.EventHandler(this.lbl_Name_Click);
            // 
            // ConfirmationDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(555, 236);
            this.Controls.Add(this.actionLabel);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.customButton2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ConfirmationDialog";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private CustomButton customButton1;
        private CustomButton customButton2;
        private System.Windows.Forms.Label actionLabel;
    }
}
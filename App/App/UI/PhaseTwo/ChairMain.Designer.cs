namespace App.UI.PhaseTwo
{
    partial class ChairMain
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
            this.assignButton = new System.Windows.Forms.Button();
            this.sendEmailsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // assignButton
            // 
            this.assignButton.BackColor = System.Drawing.SystemColors.Control;
            this.assignButton.Location = new System.Drawing.Point(28, 27);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(108, 49);
            this.assignButton.TabIndex = 0;
            this.assignButton.Text = "ASSIGN";
            this.assignButton.UseVisualStyleBackColor = false;
            this.assignButton.Click += new System.EventHandler(this.assignButton_Click);
            // 
            // sendEmailsButton
            // 
            this.sendEmailsButton.BackColor = System.Drawing.SystemColors.Control;
            this.sendEmailsButton.Location = new System.Drawing.Point(28, 82);
            this.sendEmailsButton.Name = "sendEmailsButton";
            this.sendEmailsButton.Size = new System.Drawing.Size(108, 49);
            this.sendEmailsButton.TabIndex = 1;
            this.sendEmailsButton.Text = "Send Emails";
            this.sendEmailsButton.UseVisualStyleBackColor = false;
            this.sendEmailsButton.Click += new System.EventHandler(this.sendEmailsButton_Click);
            // 
            // ChairMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(165, 153);
            this.Controls.Add(this.sendEmailsButton);
            this.Controls.Add(this.assignButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(181, 192);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(181, 192);
            this.Name = "ChairMain";
            this.ShowIcon = false;
            this.Text = "ChairMain";
            this.Load += new System.EventHandler(this.ChairMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.Button sendEmailsButton;
    }
}
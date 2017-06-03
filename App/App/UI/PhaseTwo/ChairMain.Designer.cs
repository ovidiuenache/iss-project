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
            this.buttonNextPhase = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
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
            // buttonNextPhase
            // 
            this.buttonNextPhase.Location = new System.Drawing.Point(28, 155);
            this.buttonNextPhase.Name = "buttonNextPhase";
            this.buttonNextPhase.Size = new System.Drawing.Size(108, 49);
            this.buttonNextPhase.TabIndex = 2;
            this.buttonNextPhase.Text = "Next Phase";
            this.buttonNextPhase.UseVisualStyleBackColor = true;
            this.buttonNextPhase.Click += new System.EventHandler(this.buttonNextPhase_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(28, 220);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(108, 49);
            this.buttonLogout.TabIndex = 3;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // ChairMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(165, 284);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonNextPhase);
            this.Controls.Add(this.sendEmailsButton);
            this.Controls.Add(this.assignButton);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(181, 323);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(181, 323);
            this.Name = "ChairMain";
            this.ShowIcon = false;
            this.Text = "ChairMain";
            this.Load += new System.EventHandler(this.ChairMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.Button sendEmailsButton;
        private System.Windows.Forms.Button buttonNextPhase;
        private System.Windows.Forms.Button buttonLogout;
    }
}
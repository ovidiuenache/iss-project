namespace App.UI.PhaseTwo
{
    partial class ChairToAcceptedAuthors
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
            this.sendEmailsButton = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sendEmailsButton
            // 
            this.sendEmailsButton.BackColor = System.Drawing.SystemColors.Control;
            this.sendEmailsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.sendEmailsButton.Location = new System.Drawing.Point(12, 12);
            this.sendEmailsButton.Name = "sendEmailsButton";
            this.sendEmailsButton.Size = new System.Drawing.Size(243, 43);
            this.sendEmailsButton.TabIndex = 0;
            this.sendEmailsButton.Text = "Send emails";
            this.sendEmailsButton.UseVisualStyleBackColor = false;
            this.sendEmailsButton.Click += new System.EventHandler(this.sendEmailsButton_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(12, 61);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(243, 43);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // ChairToAcceptedAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 112);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.sendEmailsButton);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChairToAcceptedAuthors";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ChairToAcceptedAuthors";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChairToAcceptedAuthors_FormClosing);
            this.Load += new System.EventHandler(this.ChairToAcceptedAuthors_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button sendEmailsButton;
        private System.Windows.Forms.Button buttonBack;
    }
}
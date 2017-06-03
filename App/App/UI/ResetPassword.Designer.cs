namespace App.UI
{
    partial class ResetPassword
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
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.resetPass = new System.Windows.Forms.Button();
            this.resetPasswordLabel = new System.Windows.Forms.Label();
            this.backToLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailTextBox
            // 
            this.emailTextBox.ForeColor = System.Drawing.Color.Black;
            this.emailTextBox.Location = new System.Drawing.Point(35, 59);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(196, 21);
            this.emailTextBox.TabIndex = 1;
            this.emailTextBox.Text = "Enter your email adress:";
            this.emailTextBox.Click += new System.EventHandler(this.emailTextBox_Click);
            // 
            // resetPass
            // 
            this.resetPass.Location = new System.Drawing.Point(138, 113);
            this.resetPass.Name = "resetPass";
            this.resetPass.Size = new System.Drawing.Size(107, 38);
            this.resetPass.TabIndex = 0;
            this.resetPass.Text = "Reset Password";
            this.resetPass.Click += new System.EventHandler(this.resetPass_Click);
            // 
            // resetPasswordLabel
            // 
            this.resetPasswordLabel.AutoSize = true;
            this.resetPasswordLabel.Location = new System.Drawing.Point(35, 23);
            this.resetPasswordLabel.Name = "resetPasswordLabel";
            this.resetPasswordLabel.Size = new System.Drawing.Size(170, 15);
            this.resetPasswordLabel.TabIndex = 2;
            this.resetPasswordLabel.Text = "Let\'s get you into your account";
            // 
            // backToLogin
            // 
            this.backToLogin.Location = new System.Drawing.Point(35, 113);
            this.backToLogin.Name = "backToLogin";
            this.backToLogin.Size = new System.Drawing.Size(87, 38);
            this.backToLogin.TabIndex = 3;
            this.backToLogin.Text = "Back";
            this.backToLogin.UseVisualStyleBackColor = true;
            this.backToLogin.Click += new System.EventHandler(this.backToLogin_Click);
            // 
            // ResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 174);
            this.Controls.Add(this.backToLogin);
            this.Controls.Add(this.resetPasswordLabel);
            this.Controls.Add(this.resetPass);
            this.Controls.Add(this.emailTextBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(283, 213);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(283, 213);
            this.Name = "ResetPassword";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ResetPassword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResetPassword_FormClosing);
            this.Load += new System.EventHandler(this.ResetPassword_Load);
            this.Click += new System.EventHandler(this.autoCompleteText);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button resetPass;
        private System.Windows.Forms.Label resetPasswordLabel;
        private System.Windows.Forms.Button backToLogin;
    }
}
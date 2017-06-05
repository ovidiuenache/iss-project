using App.Context;
using App.Controller;
using App.Utils;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace App.UI
{ /// <summary>
  /// 
  /// Reset Password
  /// Author: Dezsi Razvan
  /// Author: Ioan Ovidiu Enache
  /// 
  /// </summary>
    public partial class ResetPassword : Form
    {
        private LoginController loginController;
        private Form parentForm;

        public ResetPassword(Form parentForm, LoginController loginController)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.loginController = loginController;
        }
        private void emailTextBox_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "Enter your email adress:")
                emailTextBox.Text = "";

        }
        private void AutoCompleteText(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "")
                emailTextBox.Text = "Enter your email adress:";
        }


        private void resetPass_Click(object sender, EventArgs e)
        {
            var mailSender = new MailSender();
            var randomString = new PasswordGenerator();
            var finalString = randomString.GetString(8);
            var messageToSent = "Your new password is: " + finalString;
            var appContext = new AppContext();
           
            if (loginController.GetUserByEmail(emailTextBox.Text)!=null)
            {
                try
                {
                    var receiverMail = new MailAddress(emailTextBox.Text);
                    loginController.ChangePassword(emailTextBox.Text, finalString);
                    mailSender.SendMail(receiverMail, messageToSent, "Conference Login Password");
                    MessageBox.Show("We've sent a new password to this email address.", "Reset Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                #pragma warning disable CS0168 // Variable is declared but never used
                catch (FormatException exception)
                #pragma warning restore CS0168 // Variable is declared but never used
                {
                    MessageBox.Show("The email adress is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
                MessageBox.Show("The email adress is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        private void backToLogin_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }

        private void ResetPassword_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Location = new System.Drawing.Point(Location.X, Location.Y);
            parentForm.Show();
        }
    }
}



    


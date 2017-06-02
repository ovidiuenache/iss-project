using App.Context;
using App.Controller;
using App.Repository.Impl;
using App.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI
{ /// <summary>
  /// 
  /// Reset Password
  /// Author: Dezsi Razvan
  /// 
  /// </summary>
    public partial class ResetPassword : Form
    {
        private LoginController loginController;
        private Form parentForm;
        public ResetPassword(Form loginForm, LoginController loginController)
        {
            InitializeComponent();
            this.parentForm = loginForm;
            this.loginController = loginController;
        }
        private void emailTextBox_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "Enter your email adress:")
                emailTextBox.Text = "";

        }
        private void autoCompleteText(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "")
                emailTextBox.Text = "Enter your email adress:";
        }


        private void resetPass_Click(object sender, EventArgs e)
        {
            MailSender mailSender = new MailSender();
            PasswordGenerator randomString = new PasswordGenerator();
            String finalString = randomString.GetString(8);
            String messageToSent = "Your new password is: " + finalString;
            AppContext appContext = new AppContext();
           
            if (loginController.GetUserByEmail(emailTextBox.Text)!=null)
            {
                try
                {
                    MailAddress receiverMail = new MailAddress(emailTextBox.Text);
                    loginController.ChangePassword(emailTextBox.Text, finalString);
                    mailSender.sendMail(receiverMail, messageToSent, "Conference Login Password");
                    MessageBox.Show("We've sent a new password to this email address.");
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
            parentForm.Location = new System.Drawing.Point(Location.X, Location.Y);
            Hide();
            parentForm.Show();
        }
    }
}



    


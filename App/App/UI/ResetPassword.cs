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
        LoginController loginController;
        Form loginForm;
        public ResetPassword(Form loginForm, LoginController loginController)
        {
            InitializeComponent();
            this.loginForm = loginForm;
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

            String finalString = RandomString(8);
            String messageToSent = "Your new password is: " + finalString;
            AppContext appContext = new AppContext();
           
          
         
            if (emailTextBox.Text != "" && loginController.GetUserByEmail(emailTextBox.Text)!=null)
            {
                try
                {
                    MailAddress receiverMail = new MailAddress(emailTextBox.Text);
                    loginController.ChangePassword(emailTextBox.Text, finalString);
                    mailSender.sendMail(receiverMail, messageToSent, "Conference Login Password");
                    MessageBox.Show("We've sent a new password to these email addresses.");
                }
                catch (FormatException exception)
                {
                    MessageBox.Show("The email adress is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
                MessageBox.Show("The email adress is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }


        public string RandomString(int length)
        {
            Random random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void backToLogin_Click(object sender, EventArgs e)
        {
            loginForm.Location = new System.Drawing.Point(Location.X, Location.Y);
            Hide();
            loginForm.Show();
        }
    }
}



    


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
{
    public partial class ResetPassword : Form
    {
        public ResetPassword()
        {
            InitializeComponent();
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter your email adress:")
                textBox1.Text = "";

        }
        private void autoCompleteText(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = "Enter your email adress:";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ResetPassword_Load(object sender, EventArgs e)
        {

        }

        private void resetPass_Click(object sender, EventArgs e)
        {
            var mailSender = new Utils.MailSender();
            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }

            var finalString1 = new String(stringChars);
            var finalString = "Your new password is: " + finalString1;

           
            if (textBox1.Text != "")
            {
                try
                {
                    MailAddress receiverMail = new MailAddress(textBox1.Text);
                    //aici radoiule trebuie sa introduci in baza de date parola din finalString!!!
                    mailSender.sendMail(receiverMail, finalString, "Conference Login Password");
                    MessageBox.Show("We've sent a new password to these email addresses.");
                    this.Hide();


                }
                catch (FormatException exception)
                {
                    MessageBox.Show("The email adress is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }else
                MessageBox.Show("The email adress is invalid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

    }
}



    


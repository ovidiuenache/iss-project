using App.Controller;
using App.Entity;
using App.Exception;
using App.Factory;
using App.Validators;
using System;
using System.Windows.Forms;

namespace App
{
    public partial class Register : Form
    {
        private PreliminaryPhaseController preliminaryController;
        private UserValidator userValidator;
        private Form parentForm;

        public Register(Form parentForm)
        {
            InitializeComponent();

            this.parentForm = parentForm;
            userValidator = new UserValidator();
            preliminaryController = ApplicationFactory.getPreliminaryPhaseController();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (textPassword.Text != textConfirmPassword.Text)
                {
                    throw new ValidationException("Password do not match!");
                }

                User newUser = new User();
                newUser.FirstName = textFirstName.Text;
                newUser.LastName = textLastName.Text;
                newUser.Country = textCountry.Text;
                newUser.Email = textEmail.Text;
                newUser.Password = textPassword.Text;

                userValidator.validate(newUser);

                preliminaryController.Register(newUser);
            }
            catch (ValidationException ex)
            {
                MessageBox.Show(ex.getMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (InvalidEmailAddressException ex)
            {
                MessageBox.Show(ex.getMessage(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Register_Load(object sender, EventArgs e)
        {
            AcceptButton = buttonRegister;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Location = new System.Drawing.Point(Location.X, Location.Y);
            parentForm.Show();
        }
    }
}
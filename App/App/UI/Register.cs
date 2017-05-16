using App.Controller;
using App.Entity;
using System;
using System.Windows.Forms;

namespace App
{
    public partial class Register : Form
    {
        Form parentForm;
        PreliminaryPhaseController preliminaryController;

        public Register(Form parentForm, PreliminaryPhaseController preliminaryController)
        {
            InitializeComponent();
            
            this.parentForm = parentForm;
            this.preliminaryController = preliminaryController;
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            parentForm.Location = new System.Drawing.Point(Location.X, Location.Y);
            parentForm.Show();
            Hide();
        }

        private void Register_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
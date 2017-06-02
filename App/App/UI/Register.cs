using App.Controller;
using App.Factory;
using System;
using System.Windows.Forms;

namespace App
{
    public partial class Register : Form
    {
        private PreliminaryPhaseController preliminaryController;
        private Form parentForm;

        public Register(Form parentForm)
        {
            InitializeComponent();

            this.parentForm = parentForm;
            preliminaryController = ApplicationFactory.getPreliminaryPhaseController();
        }


        private void buttonRegister_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
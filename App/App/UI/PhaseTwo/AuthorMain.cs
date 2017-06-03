using App.Controller;
using App.Entity;
using App.Factory;
using System;
using System.Windows.Forms;

namespace App.UI.PhaseTwo
{
    public partial class AuthorMain : Form
    {
        private PhaseOneController controller;
        private Proposal proposal;
        private User loggedUser;
        private Form parentForm;

        public AuthorMain(Form parentForm, User loggedUser)
        {
            this.controller = ApplicationFactory.getPhaseOneController();

            //TO DO
            //LOAD THIS PROPOSAL SOMEHOW FROM THE DATABASE
            proposal = null;


            this.loggedUser = loggedUser;
            this.parentForm = parentForm;

            InitializeComponent();
        }



        private void buttonUploadFull_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text == "")
                MessageBox.Show("Please select a file to upload");
            else
            {   
                MetaInformation mt = new MetaInformation(proposal, controller, true, textBox1.Text);
                mt.Show();
            }
        }

        private void buttonBrowseFull_Click(object sender, EventArgs e)
        {
            this.openFileDialogBrowse.Title = "Upload full paper";
            openFileDialogBrowse.Filter = "PDF files (*.pdf)|*.pdf|Microsoft Word Files (*.docx)|*.docx";
            if (openFileDialogBrowse.ShowDialog() == DialogResult.OK)
            {
                this.textBox1.Text = openFileDialogBrowse.FileName;
            }
        }

        private void AuthorMain_Load(object sender, EventArgs e)
        {

        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            parentForm.Location = new System.Drawing.Point(Location.X, Location.Y);
            parentForm.Show();
            Close();
        }

        private void AuthorMain_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
    }
}

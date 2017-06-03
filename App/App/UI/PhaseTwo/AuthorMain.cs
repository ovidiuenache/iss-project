using App.Controller;
using App.Entity;
using System;
using System.Windows.Forms;

namespace App.UI.PhaseTwo
{
    public partial class AuthorMain : Form
    {
        private PhaseOneController controller;
        private Proposal proposal;
        private User user;
        public AuthorMain(PhaseOneController controller, Proposal proposal, User author)
        {
            this.controller = controller;
            this.proposal = proposal;
            this.user = author;
            InitializeComponent();
        }



        private void buttonUploadFull_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                MessageBox.Show("Please select a file to upload");
            else
            {   
                MetaInformation mt = new MetaInformation(proposal, true, textBox1.Text);
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
    }
}

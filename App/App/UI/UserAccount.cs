using App.Controller;
using App.Entity;
using App.Factory;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace App.UI
{
    /// <summary>
    /// Authors: Alexandru Popa, Vancea Vlad, Ioan Ovidiu Enache
    /// The class that manages the phase 1 about proposals
    /// </summary>
    public partial class UserAccount : Form
    {
        private PhaseOneController controller;
        private User loggedUser;
        private Form parentForm;

        public UserAccount(Form parentForm, User loggedUser)
        {
            controller = ApplicationFactory.getPhaseOneController();
            this.loggedUser = loggedUser;
            this.parentForm = parentForm;

            InitializeComponent();

            dataGridViewProposals.DataSource = controller.ProposalsAuthoredByUser(loggedUser.UserId);
        }

        private void buttonBrowseAbstract_Click(object sender, EventArgs e)
        {
            openFileDialogAbstract = new OpenFileDialog();
            openFileDialogAbstract.Title = "Upload abstract";
            openFileDialogAbstract.Filter = "PDF files (*.pdf)|*.pdf|Microsoft Word Files (*.docx)|*.docx";

            if(openFileDialogAbstract.ShowDialog() == DialogResult.OK)
            {
                textBoxAbstract.Text = openFileDialogAbstract.FileName;
            }
        }

        private void buttonUploadAbstract_Click(object sender, EventArgs e)
        {
            if(textBoxAbstract.Text == "")
                MessageBox.Show("Please select a file to upload");
            else
            {
                if(dataGridViewProposals.Rows.Count != 0)
                {
                    MetaInformation mt = new MetaInformation(controller.getProposal(Int32.Parse(dataGridViewProposals.SelectedRows[0].Cells[0].Value.ToString())), false, textBoxAbstract.Text);
                    mt.Show();

                }
                else
                {
                    MetaInformation mt= new MetaInformation(null, false, textBoxAbstract.Text);
                    mt.Show();

                }

            }

            dataGridViewProposals.DataSource = controller.ProposalsAuthoredByUser(loggedUser.UserId);
        }

        private void buttonUploadFull_Click(object sender, EventArgs e)
        {
            if (textBoxFull.Text == "")
                MessageBox.Show("Please select a file to upload");
            else
            {
                if(dataGridViewProposals.Rows.Count != 0)
                {
                    MetaInformation mt = new MetaInformation(controller.getProposal(Int32.Parse(dataGridViewProposals.SelectedRows[0].Cells[0].Value.ToString())), true, textBoxFull.Text);
                    mt.Show();
                }
                else
                {
                    MetaInformation mt = new MetaInformation(null, true, textBoxFull.Text);
                    mt.Show();

                }
            }

            dataGridViewProposals.DataSource = controller.ProposalsAuthoredByUser(loggedUser.UserId);
        }

        private void buttonBrowseFull_Click(object sender, EventArgs e)
        {
            openFileDialogFull.Title = "Upload full paper";
            openFileDialogFull.Filter = "PDF files (*.pdf)|*.pdf|Microsoft Word Files (*.docx)|*.docx";

            if (openFileDialogFull.ShowDialog() == DialogResult.OK)
            {
                textBoxFull.Text = openFileDialogFull.FileName;
            }
        }
        /// <summary>
        /// Get the proposals who have fullpaper and if the user do not have fullpapers the func will 
        /// return null
        /// </summary>
        /// <returns></returns>
        private IList<Proposal> getProposalsWithFullPaper()
        {
            var proposals = this.dataGridViewProposals.DataSource as List<Proposal>;
            IList<Proposal> result = new List<Proposal>();
            var emptyArray = new Proposal[0]; 

            if (proposals.Count != 0)
            {
                
                foreach (Proposal proposal in proposals)
                {
                    if(!proposal.FullPaper.Equals(""))
                    {
                        result.Add(proposal);
                    }                
                }
                return result;
            }
            else
                return emptyArray;       
        }

        private IList<Proposal> getProposalsToTheNextPhase(Phase phase)
        {
            var emptyArray = new Proposal[0];
            if (DateTime.Now > phase.Deadline)
            {
                //the next phase will have the proposals finals
                return getProposalsWithFullPaper();
            }
            else
            {
                MessageBox.Show("Users can upload proposals");
            }
            return emptyArray;
        }

        private void UserAccount_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridViewProposals.EndEdit();
            controller.saveChanges();

            MessageBox.Show("Database has been updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            parentForm.Location = new System.Drawing.Point(Location.X, Location.Y);
            parentForm.Show();
            Close();
        }
    }
}

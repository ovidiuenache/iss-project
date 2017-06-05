using App.Controller;
using App.Entity;
using App.Factory;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

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
            controller = ApplicationFactory.GetPhaseOneController();
            this.loggedUser = loggedUser;
            this.parentForm = parentForm;

            InitializeComponent();

            dataGridViewProposals.DataSource = controller.ProposalsAuthoredByUser(loggedUser.UserId);
            dataGridViewProposals.Columns[2].Visible = false;
            dataGridViewProposals.Columns[7].Visible = false;

            buttonUpdate.Size = new System.Drawing.Size(633, 34);
            buttonUpdate.Location = new System.Drawing.Point(36, 280);

            if (controller.GetUserRoles(loggedUser).Select(role => role.Slug).Contains("chair"))
            {
                buttonNextPhase.Visible = true;
                buttonUpdate.Size = new System.Drawing.Size(321, 34);
                buttonUpdate.Location = new System.Drawing.Point(36, 280);
            }
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
                    var mt = new MetaInformation(controller.GetProposal(Int32.Parse(dataGridViewProposals.Rows[0].Cells[0].Value.ToString())), false, textBoxAbstract.Text);
                    mt.Show();

                }
                else
                {
                    var mt= new MetaInformation(null, false, textBoxAbstract.Text);
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
                    var mt = new MetaInformation(controller.GetProposal(Int32.Parse(dataGridViewProposals.Rows[0].Cells[0].Value.ToString())), true, textBoxFull.Text);
                    mt.Show();
                }
                else
                {
                    var mt = new MetaInformation(null, true, textBoxFull.Text);
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
                
                foreach (var proposal in proposals)
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

        private IList<Proposal> GetProposalsToTheNextPhase(Phase phase)
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
            controller.SaveChanges();

            MessageBox.Show("Database has been updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            parentForm.Location = new System.Drawing.Point(Location.X, Location.Y);
            parentForm.Show();
            Close();
        }

        private void UserAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            parentForm.Location = new System.Drawing.Point(Location.X, Location.Y);
            parentForm.Show();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewProposals.DataSource = controller.ProposalsAuthoredByUser(loggedUser.UserId);
        }

        private void buttonNextPhase_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Are you sure you want to start the next phase?", "Next Phase", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var activeConference = controller.ActiveConference();

                var nextPhase = new Phase();
                nextPhase.Deadline = activeConference.EndDate;
                nextPhase.Name = "PHASETWO";

                activeConference.ActivePhase = nextPhase;

                controller.UpdateConference(activeConference);
                controller.deleteProposalsWithoutFull();
                controller.UpdateUserRoles();

                MessageBox.Show("Next phase has successfully started!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                //do nothing
            }
        }
    }
}

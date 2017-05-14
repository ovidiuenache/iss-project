using App.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI
{
    /// <summary>
    /// Authors: Alexandru Popa, Vancea Vlad
    /// The class who manage the phase 1 about proposals
    /// </summary>
    public partial class UserAccount : Form
    {
        private ProposalController controller;
        private User user;
        public UserAccount()
        {
            controller = new ProposalController();
            InitializeComponent();
        }

        private void buttonBrowseAbstract_Click(object sender, EventArgs e)
        {
            //openFileDialogAbstract = new OpenFileDialog();
            openFileDialogAbstract.Title = "Upload abstract";
            openFileDialogAbstract.Filter = "PDF files (*.pdf)|*.pdf|Microsoft Word Files (*.docx)|*.docx";

            if(openFileDialogAbstract.ShowDialog() == DialogResult.OK)
            {
                textBoxAbstract.Text = openFileDialogAbstract.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxAbstract.Text == "")
                MessageBox.Show("Please select a file to upload");
            else
            {
                if(dataGridViewProposals.Rows.Count != 0)
                {
                    MetaInformation mt = new MetaInformation(controller.getProposal(Int32.Parse(dataGridViewProposals.SelectedRows[0].Cells[0].Value.ToString())), controller, false, textBoxAbstract.Text);
                    mt.Show();

                }
                else
                {
                    MetaInformation mt= new MetaInformation(null, controller, false, textBoxAbstract.Text);
                    mt.Show();

                }

            }
        }

        private void buttonUploadFull_Click(object sender, EventArgs e)
        {
            if (textBoxFull.Text == "")
                MessageBox.Show("Please select a file to upload");
            else
            {
                if(dataGridViewProposals.Rows.Count != 0)
                {
                    MetaInformation mt = new MetaInformation(controller.getProposal(Int32.Parse(dataGridViewProposals.SelectedRows[0].Cells[0].Value.ToString())), controller, true, textBoxFull.Text);
                    mt.Show();
                }
                else
                {
                    MetaInformation mt = new MetaInformation(null, controller, true, textBoxFull.Text);
                    mt.Show();

                }
            }
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
        /// get the proposals who have fullpaper and if the user do not have fullpapers the func will 
        /// return null. Author: Vlad
        /// </summary>
        /// <returns></returns>
        private IList<Proposal> getProposalsWithFullPaper()
        {
            var proposals = this.dataGridViewProposals.DataSource as List<Proposal>;
            IList<Proposal> result = new List<Proposal>();

            foreach(Proposal proposal in proposals)
            {
                if(proposal.FullPaper.Equals(""))
                {
                    result.Add(proposal);
                }                
            }
            if (proposals.Count != 0)
                return result;
            else
                return null;
        }

        private IList<Proposal> getProposalsToTheNextPhase(Phase phase)
        {
            if(DateTime.Now > phase.Deadline)
            {
                //the next phase will have the proposals finals
                return getProposalsWithFullPaper();
            }
            else
            {
                MessageBox.Show("Users can upload proposals");
            }
            return null;
        }

    }
}

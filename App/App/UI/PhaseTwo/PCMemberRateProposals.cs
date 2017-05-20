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

namespace App.UI.PhaseTwo
{
    public partial class PCMemberRateProposals : Form
    {

        private List<Proposal> proposals;
        private User reviewer;
        private PhaseTwoController phaseTwoController;

        public PCMemberRateProposals(List<Proposal> proposals, User reviewer, PhaseTwoController phaseTwoController)
        {
            this.proposals = proposals;
            this.reviewer = reviewer;
            this.phaseTwoController = phaseTwoController;
            initProposalsDataGridView();
            InitializeComponent();
        }

        private void initProposalsDataGridView()
        {
            BindingList<Proposal> bindingList = new BindingList<Proposal>(proposals);
            BindingSource source = new BindingSource(bindingList, null);
            proposalsDataGridView.DataSource = source;
        }
        
        private void submitButton_Click(object sender, EventArgs e)
        {
            RadioButton checkedReviewButton = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            Proposal prop = phaseTwoController.findProposalById(int.Parse(proposalsDataGridView.CurrentRow.Cells[0].Value.ToString()));
            Review review = new Review(checkedReviewButton.Text, commentsRichTextBox.Text, this.reviewer, prop, DateTime.Now);
            phaseTwoController.AddReview(review);
        }


        private void proposalsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if(phaseTwoController.findReviewByIdProposalIdReviewer(int.Parse(proposalsDataGridView.CurrentRow.Cells[0].Value.ToString()),reviewer.UserId))
            {
                submitButton.Enabled = false;
            }
        }
    }
}

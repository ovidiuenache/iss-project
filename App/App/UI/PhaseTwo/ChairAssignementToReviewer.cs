using App.Controller;
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
    public partial class ChairAssignementToReviewer : Form
    {
        private PhaseTwoController phaseTwoController;
        public ChairAssignementToReviewer(PhaseTwoController phaseTwoController)
        {
            this.phaseTwoController = phaseTwoController;
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            List<User> reviewers = new List<User>();
            List<Review> reviews;
            reviews = phaseTwoController.getReviewsByProposalId(Int32.Parse(proposalsDataGridView.CurrentRow.Cells[0].ToString()));
            foreach (DataGridViewRow row in reviewersDataGridView.SelectedRows)
            {
                User reviewer = phaseTwoController.getReviewerById(Int32.Parse(row.Cells[0].ToString()));
                reviewers.Add(reviewer);
            }
            foreach(Review rev in reviews)
            {
                if(!reviewers.Contains(rev.Reviewer))
                {
                    phaseTwoController.removeReview(rev.ReviewId);
                    continue;
                }
            }
        }
    }
}

using App.Controller;
using App.Entity;
using App.Factory;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


/// <summary>
/// Author: Diana Gociu,Andu Popa
/// </summary>
namespace App.UI.PhaseTwo
{
    public partial class ChairAssignementToReviewer : Form
    {
        private PhaseTwoController phaseTwoController;
        private ChairMain parent;

        public ChairAssignementToReviewer(ChairMain parent)
        {
            this.parent = parent;
            phaseTwoController = ApplicationFactory.GetPhaseTwoController();

            InitializeComponent();
            proposalsDataGridView.DataSource = phaseTwoController.GetProposals();
            reviewersDataGridView.DataSource = phaseTwoController.GetReviewers();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            var reviewers = new List<User>();
            List<Review> reviews;
            reviews = phaseTwoController.GetReviewsByProposalId(Int32.Parse(proposalsDataGridView.CurrentRow.Cells[0].Value.ToString()));
            foreach (DataGridViewRow row in reviewersDataGridView.SelectedRows)
            {
                var reviewer = phaseTwoController.GetReviewer(Int32.Parse(row.Cells[0].Value.ToString()));
                reviewers.Add(reviewer);
            }
            foreach(var rev in reviews)
            {
                if(!reviewers.Contains(rev.Reviewer))
                {
                    phaseTwoController.RemoveReview(rev.ReviewId);
                }
            }

            MessageBox.Show("Proposal assigned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ChairAssignementToReviewer_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void ChairAssignementToReviewer_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            parent.Location = new System.Drawing.Point(Location.X, Location.Y);
            parent.Show();
            Close();
        }
    }
}

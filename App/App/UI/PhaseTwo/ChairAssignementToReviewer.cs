﻿using App.Controller;
using App.Entity;
using App.Factory;
using System;
using System.Collections.Generic;
using System.Windows.Forms;


/// <summary>
/// Author: Diana Gociu
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
            phaseTwoController = ApplicationFactory.getPhaseTwoController();

            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            List<User> reviewers = new List<User>();
            List<Review> reviews;
            reviews = phaseTwoController.getReviewsByProposalId(Int32.Parse(proposalsDataGridView.CurrentRow.Cells[0].ToString()));
            foreach (DataGridViewRow row in reviewersDataGridView.SelectedRows)
            {
                User reviewer = phaseTwoController.getReviewer(Int32.Parse(row.Cells[0].ToString()));
                reviewers.Add(reviewer);
            }
            foreach(Review rev in reviews)
            {
                if(!reviewers.Contains(rev.Reviewer))
                {
                    phaseTwoController.removeReview(rev.ReviewId);
                }
            }
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

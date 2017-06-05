﻿using App.Controller;
using App.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace App.UI.PhaseTwo
{
    /// <summary>
    /// Author: Andu Popa
    /// </summary>
    public partial class PCMemberRateProposals : Form
    {

        private List<Review> reviews;
        private User reviewer;
        private PhaseTwoController phaseTwoController;
        private PCMemberMain parent;

        public PCMemberRateProposals(PCMemberMain parent, List<Review> reviews, User reviewer, PhaseTwoController phaseTwoController)
        {
            this.parent = parent;
            this.reviews = reviews;
            this.reviewer = reviewer;
            this.phaseTwoController = phaseTwoController;
            InitializeComponent();

            proposalsDataGridView.DataSource = reviews;
        }

        private void InitProposalsDataGridView()
        {
            var bindingList = new BindingList<Review>(reviews);
            var source = new BindingSource(bindingList, null);
            proposalsDataGridView = new DataGridView();
            proposalsDataGridView.DataSource = source;
        }
        
        private void submitButton_Click(object sender, EventArgs e)
        {
            var checkedReviewButton = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            var review = phaseTwoController.GetReview(int.Parse(proposalsDataGridView.CurrentRow.Cells[0].Value.ToString()));
            review.Qualifier = checkedReviewButton.Text;
            review.Comment = commentsRichTextBox.Text;
            review.DateCreated = DateTime.Now;
            phaseTwoController.UpdateReview(review);

            MessageBox.Show("Review was made successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void proposalsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            //if(phaseTwoController.getReviewByIdProposalIdReviewer(int.Parse(proposalsDataGridView.CurrentRow.Cells[0].Value.ToString()),this.reviewer.UserId)!=null)
            //{
                submitButton.Enabled = true;
            //}
        }

        private void PCMemberRateProposals_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            parent.Location = new Point(Location.X, Location.Y);
            parent.Show();
            Close();
        }

        private void PCMemberRateProposals_Load(object sender, EventArgs e)
        {

        }
    }
}

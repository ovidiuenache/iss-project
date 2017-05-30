﻿using App.Controller;
using App.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;



namespace App.UI.PhaseTwo
{
    /// <summary>
    /// Author : Vancea Vladut, Andu Popa
    /// </summary>
    public partial class PCMemberBidProposals : Form
    {
        private PCMemberMain parent;
        private List<Proposal> proposals;
        private User reviewer;
        private PhaseTwoController phaseTwoController;

        public PCMemberBidProposals(PCMemberMain parent, PhaseTwoController phaseTwoController, User reviewer)
        {
            this.parent = parent;
            this.proposals = phaseTwoController.getProposals();
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

            if (checkedReviewButton.Text.Equals("I want") || checkedReviewButton.Text.Equals("I can"))
            {
                Review review = new Review("", "", reviewer, prop, new DateTime(2000,01,01));
                phaseTwoController.addReview(review);
            }
        }

        private void proposalsDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (phaseTwoController.findReviewByIdProposalIdReviewer(int.Parse(proposalsDataGridView.CurrentRow.Cells[0].Value.ToString()), reviewer.UserId))
            {
                submitButton.Enabled = false;
            }
        }

        private void PCMemberBidProposals_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            parent.SetDesktopLocation(this.Location.X, this.Location.Y);
            parent.Show();
        }
    }
}

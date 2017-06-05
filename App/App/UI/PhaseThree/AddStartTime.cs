using System;
using System.Windows.Forms;
using App.Controller;
using App.Entity;
using App.Factory;

namespace App.UI.PhaseThree
{
    public partial class AddStartTime : Form
    {
        private Proposal Proposal;
        private IPhaseThreeController Controller;

        public AddStartTime(Proposal proposal)
        {
            InitializeComponent();
            Proposal = proposal;
            labelProposalTitle.Text = Proposal.Title;
            Controller = ApplicationFactory.GetPhaseThreeController();
            dateTimePickerProposalTime.Format = DateTimePickerFormat.Custom;
            dateTimePickerProposalTime.CustomFormat = "MM/dd/yyyy HH:mm";
            dateTimePickerProposalTime.MinDate = Controller.GetActiveConference().StartDate;
            dateTimePickerProposalTime.MaxDate = Controller.GetActiveConference().EndDate;
        }

        private void AddStartTime_Load(object sender, EventArgs e)
        {

        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            Proposal.StartTime = dateTimePickerProposalTime.Value;
            Controller.UpdateProposal(Proposal);
            this.Hide();
            MessageBox.Show("Proposals has been successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

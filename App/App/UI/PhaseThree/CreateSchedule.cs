using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using App.Controller;
using App.Entity;
using App.Factory;

namespace App.UI.PhaseThree
{
    public partial class CreateSchedule : Form
    {
        private IPhaseThreeController PhaseThreeController;
        private Form ParentForm;

        public CreateSchedule(Form parentForm)
        {
            InitializeComponent();
            PhaseThreeController = ApplicationFactory.GetPhaseThreeController();
            LoadSections();
            btnAddToSection.Enabled = false;
            ParentForm = parentForm;
        }

        private void LoadSections()
        {
            if (PhaseThreeController != null)
            {
                List<Section> sections = PhaseThreeController.FindAllSections();
                foreach (var section in sections)
                {
                    comboBoxSections.Items.Add(section);
                }

                comboBoxSections.DisplayMember = "Name";
            }
        }

        private void comboBoxSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProposals();
        }

        private void LoadProposals()
        {
            listBoxProposals.Items.Clear();
            List<Proposal> proposals =
                PhaseThreeController.FindAllProposalsWithoutSection();

            foreach (var proposal in proposals)
            {
                listBoxProposals.Items.Add(proposal.Title);
            }
            btnAddToSection.Enabled = true;
        }

        private void btnAddToSection_Click(object sender, EventArgs e)
        {
            Section section = (Section)comboBoxSections.SelectedItem;
            Proposal proposal = PhaseThreeController.FindProposalByName(listBoxProposals.SelectedItem.ToString());
            try
            {
                PhaseThreeController.AddProposalToSection(section, proposal);
                LoadProposals();
                PopupAddStartTime(proposal);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopupAddStartTime(Proposal proposal)
        {
            Form addStartTimeForm = new AddStartTime(proposal);
            addStartTimeForm.Show();
        }

        private void btnChooseRoom_Click(object sender, EventArgs e)
        {
            Form chooseRoomForm = new ChooseRoom(this);
            chooseRoomForm.Show();
            Hide();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ParentForm.Location = new Point(Location.X, Location.Y);
            ParentForm.Show();
            Close();
        }
    }
}

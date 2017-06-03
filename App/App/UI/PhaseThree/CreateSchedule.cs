using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Controller;
using App.Entity;
using App.Factory;

namespace App.UI.PhaseThree
{
    public partial class CreateSchedule : Form
    {
        private IPhaseThreeController PhaseThreeController;
        public CreateSchedule()
        {
            InitializeComponent();
            PhaseThreeController = ApplicationFactory.GetPhaseThreeController();
            LoadSections();
            btnAddToSection.Enabled = false;
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
            Section section = (Section)comboBoxSections.SelectedItem;
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
    }
}

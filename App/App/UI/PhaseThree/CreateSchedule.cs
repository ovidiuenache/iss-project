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
            List<ProposalMetaInformation> proposalMetaInformations =
                PhaseThreeController.FindAllProposalsBySection(section);

            foreach (var proposal in proposalMetaInformations)
            {
                listBoxProposals.Items.Add(proposal.Title);
            }
        }
    }
}

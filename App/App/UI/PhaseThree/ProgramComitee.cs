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
    public partial class ProgramComitee : Form
    {
        private PhaseThreeController PhaseThreeController;

        public ProgramComitee()
        {
            InitializeComponent();
            PhaseThreeController = ApplicationFactory.GetPhaseThreeController();
            LoadSections();
            btnSectionLeader.Enabled = false;
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

        private void btnSectionLeader_Click(object sender, EventArgs e)
        {
            try
            {
                //@todo: save the leader of section(set section id from user repo)
                PhaseThreeController.AddSectionLeader((User)comboBoxComiteeMembers.SelectedItem);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void comboBoxSections_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadComiteeMembers();
        }

        private void LoadComiteeMembers()
        {
            comboBoxComiteeMembers.Items.Clear();
            //@todo: FindAllComiteeMember must return a list with 
            // all users that have the following roles: chair or reviewer

            List<User> comiteeMembers = PhaseThreeController.FindAllComiteeMemberWithoutSection();

            foreach (var member in comiteeMembers)
            {
                comboBoxComiteeMembers.Items.Add(member);
            }

            comboBoxSections.DisplayMember = "Last Name";
        }

        private void comboBoxComiteeMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSectionLeader.Enabled = true;
        }

        private void ProgramComitee_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            Form createScheduleForm = new CreateSchedule(this);
            createScheduleForm.Show();
            Hide();
        }
    }
}

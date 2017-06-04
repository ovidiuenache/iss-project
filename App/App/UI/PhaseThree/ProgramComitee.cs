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
        private Form ParentForm;

        public ProgramComitee(Form parentForm)
        {
            InitializeComponent();
            PhaseThreeController = ApplicationFactory.GetPhaseThreeController();
            LoadSections();
            btnSectionLeader.Enabled = false;
            ParentForm = parentForm;
        }

        private void LoadSections()
        {
            comboBoxSections.Items.Clear();
            if (PhaseThreeController != null)
            {
                List<Section> sections = PhaseThreeController.FindAllSectionsWithoutLeader();
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
                PhaseThreeController.AddSectionLeader(
                    (Section)comboBoxSections.SelectedItem, 
                    (User)comboBoxComiteeMembers.SelectedItem
                    );
                LoadSections();
                LoadComiteeMembers();
                MessageBox.Show("Section leader has been successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            ParentForm.Location = new Point(Location.X, Location.Y);
            ParentForm.Show();
            Close();
        }
    }
}

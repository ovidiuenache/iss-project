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
    public partial class ChooseRoom : Form
    {
        private IPhaseThreeController PhaseThreeController;
        private Form ParentForm;

        public ChooseRoom(Form parentForm)
        {
            InitializeComponent();
            PhaseThreeController = ApplicationFactory.GetPhaseThreeController();
            LoadSections();
            btnAddRoomName.Enabled = false;
            ParentForm = parentForm;
        }

        private void LoadSections()
        {
            comboBoxSections.Items.Clear();
            if (PhaseThreeController != null)
            {
                List<Section> sections = PhaseThreeController.FindAllSectionsWithoutRoom();
                foreach (var section in sections)
                {
                    comboBoxSections.Items.Add(section);
                }

                comboBoxSections.DisplayMember = "Name";
            }
        }

        private void btnAddRoomName_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBoxRoomName.Text))
            {
                Section section = (Section)comboBoxSections.SelectedItem;
                try
                {
                    PhaseThreeController.AddSectionRoom(section, textBoxRoomName.Text.Trim());
                    LoadSections();
                    textBoxRoomName.Clear();
                    btnAddRoomName.Enabled = false;
                    MessageBox.Show("Room has been successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void textBoxRoomName_TextChanged(object sender, EventArgs e)
        {
            btnAddRoomName.Enabled = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ParentForm.Location = new Point(Location.X, Location.Y);
            ParentForm.Show();
            Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ParentForm.Location = new Point(Location.X, Location.Y);
            ParentForm.Show();
            Close();
        }
    }
}

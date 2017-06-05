using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using App.Controller;
using App.Entity;
using App.Factory;

namespace App.UI.PhaseThree
{
    public partial class ListenerMain : Form
    {
        private PhaseThreeController PhaseThreeController;
        private User LoggedUser;
        private Form ParentForm;

        public ListenerMain(Form parentForm, User loggedUser)
        {
            InitializeComponent();
            PhaseThreeController = ApplicationFactory.GetPhaseThreeController();
            ParentForm = parentForm;
            LoggedUser = loggedUser;
        }

        private void ListenerMain_Load(object sender, EventArgs e)
        {
            LoadSections();
        }

        private void LoadSections()
        {
            listBoxTopics.Items.Clear();
            var topics = PhaseThreeController.FindAllUnassignedSections(LoggedUser);

            foreach (var section in topics)
            {
                listBoxTopics.Items.Add(section.Name);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedSections = new List<Section>();
                foreach (int i in listBoxTopics.SelectedIndices)
                {
                    var sectionName = listBoxTopics.Items[i].ToString();
                    selectedSections.Add(PhaseThreeController.FindSectionByName(sectionName));
                }
                PhaseThreeController.AddListenerToSections(selectedSections, LoggedUser);
                LoadSections();
                MessageBox.Show("Section has been successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ParentForm.Location = new Point(Location.X, Location.Y);
            ParentForm.Show();
            Close();
        }

        private void btnChooseRoom_Click(object sender, EventArgs e)
        {

        }
    }
}

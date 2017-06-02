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
    public partial class ListenerMain : Form
    {
        private PhaseThreeController PhaseThreeController;
        private User LoggedUser;

        public ListenerMain(User loggedUser)
        {
            InitializeComponent();
            PhaseThreeController = ApplicationFactory.GetPhaseThreeController();
            LoggedUser = loggedUser;
        }

        private void ListenerMain_Load(object sender, EventArgs e)
        {
            LoadSections();
        }

        private void LoadSections()
        {
            List<Section> topics = PhaseThreeController.FindAllTopics();

            foreach (Section section in topics)
            {
                listBoxTopics.Items.Add(section.Name);
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            List<Section> selectedSections = new List<Section>();
            foreach (int i in listBoxTopics.SelectedIndices)
            {
                string sectionName = listBoxTopics.Items[i].ToString();
                selectedSections.Add(PhaseThreeController.FindSectionByName(sectionName));
            }
            PhaseThreeController.AddListenerToSections(selectedSections, LoggedUser);
        }
    }
}

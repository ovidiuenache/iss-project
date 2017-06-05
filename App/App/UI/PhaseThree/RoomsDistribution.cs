using App.Controller;
using App.Factory;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace App.UI.PhaseThree
{
    public partial class RoomsDistribution : Form
    {
        private Form ParentForm;
        private PhaseThreeController phaseThreeController;

        public RoomsDistribution(Form parentForm)
        {
            InitializeComponent();
            ParentForm = parentForm;
            phaseThreeController = ApplicationFactory.GetPhaseThreeController();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            ParentForm.Location = new Point(Location.X, Location.Y);
            ParentForm.Show();
            Close();
        }

        private void btnPickSectionLeader_Click(object sender, EventArgs e)
        {
            Form programComitee = new ProgramComitee(this);
            programComitee.Location = new Point(Location.X, Location.Y);
            programComitee.Show();
            Hide();
        }

        private void btnScheduleSetup_Click(object sender, EventArgs e)
        {
            Form scheduleForm = new CreateSchedule(this);
            scheduleForm.Location = new Point(Location.X, Location.Y);
            scheduleForm.Show();
            Hide();
        }

        private void btnChooseRooms_Click(object sender, EventArgs e)
        {
            Form choseRoomForm = new ChooseRoom(this);
            choseRoomForm.Location = new Point(Location.X, Location.Y);
            choseRoomForm.Show();
            Hide();
        }

        private void buttonEndConference_Click(object sender, EventArgs e)
        {
            phaseThreeController.deleteReviews();
            phaseThreeController.deleteProposals();
            phaseThreeController.deleteTopics();
            phaseThreeController.deleteConferences();
            phaseThreeController.deletePhases();

            MessageBox.Show("Conference has successfully ended!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }
    }
}

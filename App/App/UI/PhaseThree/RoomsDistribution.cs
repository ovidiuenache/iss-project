using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI.PhaseThree
{
    public partial class RoomsDistribution : Form
    {
        private Form ParentForm;

        public RoomsDistribution(Form parentForm)
        {
            InitializeComponent();
            ParentForm = parentForm;
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
            programComitee.Show();
            Hide();
        }

        private void btnScheduleSetup_Click(object sender, EventArgs e)
        {
            Form scheduleForm = new CreateSchedule(this);
            scheduleForm.Show();
            Hide();
        }

        private void btnChooseRooms_Click(object sender, EventArgs e)
        {
            Form choseRoomForm = new ChooseRoom(this);
            choseRoomForm.Show();
            Hide();
        }
    }
}

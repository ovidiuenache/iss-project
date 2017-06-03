using App.Entity;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace App.UI.PhaseTwo
{
    /// <summary>
    /// Author : Ioan Ovidiu Enache
    /// </summary>
    public partial class ListenerMain : Form
    {
        private Form parentForm;
        private User loggedUser;

        public ListenerMain(Form parentForm, User loggedUser)
        {
            this.parentForm = parentForm;
            this.loggedUser = loggedUser;

            InitializeComponent();

            label1.Text = "Hello " + loggedUser.LastName + " " + loggedUser.FirstName;
        }

        private void ListenerMain_Load(object sender, EventArgs e)
        {
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            parentForm.Location = new Point(Location.X, Location.Y);
            parentForm.Show();
            Close();
        }
    }
}

using App.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App.UI
{
    public partial class UserAccount : Form
    {
        private ProposalController controller;
        private User user;
        public UserAccount(ProposalController ctrl, User user)
        {
            this.controller = ctrl;
            this.user = user;
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-MIOBI9T\SQLEXPRESS;Initial Catalog=iss;Integrated Security=True");
            BindingSource bs = new BindingSource();
            SqlDataAdapter da = new SqlDataAdapter();
            DataSet ds = new DataSet();
            dataGridViewProposals = new DataGridView();

            connection.Open();
            da.SelectCommand = new SqlCommand("select * from Proposals", connection);
            //da.SelectCommand.Parameters.Add("@idUser", user.UserId);
            da.Fill(ds, "Proposals");
            bs.DataSource = ds;
            bs.DataMember = "Proposals";
            
            dataGridViewProposals.DataSource = bs;
            connection.Close();

            InitializeComponent();
        }

        private void buttonBrowseAbstract_Click(object sender, EventArgs e)
        {
            //openFileDialogAbstract = new OpenFileDialog();
            openFileDialogAbstract.Title = "Upload abstract";
            openFileDialogAbstract.Filter = "PDF files (*.pdf)|*.pdf|Microsoft Word Files (*.docx)|*.docx";

            if(openFileDialogAbstract.ShowDialog() == DialogResult.OK)
            {
                textBoxAbstract.Text = openFileDialogAbstract.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxAbstract.Text == "")
                MessageBox.Show("Please select a file to upload");
            else
            {
                if(dataGridViewProposals.Rows.Count != 0)
                {
                    MetaInformation mt = new MetaInformation(controller.getProposal(Int32.Parse(dataGridViewProposals.SelectedRows[0].Cells[0].Value.ToString())), controller, false, textBoxAbstract.Text);
                    mt.Show();

                }
                else
                {
                    MetaInformation mt= new MetaInformation(new Proposal(new ProposalMetaInformation(),"",""), controller, false, textBoxAbstract.Text);
                    mt.Show();

                }

            }
        }

        private void buttonUploadFull_Click(object sender, EventArgs e)
        {
            if (textBoxFull.Text == "")
                MessageBox.Show("Please select a file to upload");
            else
            {
                if(dataGridViewProposals.Rows.Count != 0)
                {
                    MetaInformation mt = new MetaInformation(controller.getProposal(Int32.Parse(dataGridViewProposals.SelectedRows[0].Cells[0].Value.ToString())), controller, true, textBoxFull.Text);
                    mt.Show();
                }
                else
                {
                    MetaInformation mt = new MetaInformation(null, controller, true, textBoxFull.Text);
                    mt.Show();

                }
            }
        }

        private void buttonBrowseFull_Click(object sender, EventArgs e)
        {
            openFileDialogFull.Title = "Upload full paper";
            openFileDialogFull.Filter = "PDF files (*.pdf)|*.pdf|Microsoft Word Files (*.docx)|*.docx";

            if (openFileDialogFull.ShowDialog() == DialogResult.OK)
            {
                textBoxFull.Text = openFileDialogFull.FileName;
            }
        }
    }
}

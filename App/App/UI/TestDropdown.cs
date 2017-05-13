using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Entity;

namespace App.UI
{
    public partial class TestDropdown : Form
    {
        public TestDropdown()
        {
            InitializeComponent();
            //this is optional if you want to do something when an item is checked
            cbcl.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cbcl_ItemCheck);
        }


        private void cbcl_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Test item = cbcl.Items[e.Index] as Test;
            //+do what you want with the item when is checked

        }

        private List<Test> populateList()
        {
            var listTest = new List<Test>();
            listTest.Add(new Test(1, "name1", "desc1"));
            listTest.Add(new Test(2, "name2", "desc2"));
            listTest.Add(new Test(3, "name3", "desc3"));
            listTest.Add(new Test(4, "name4", "desc4"));
            listTest.Add(new Test(5, "name5", "desc5"));
            listTest.Add(new Test(6, "name6", "desc6"));
            listTest.Add(new Test(7, "name7", "desc7"));

            return listTest;
        }

        private void TestDropdown_Load_1(object sender, EventArgs e)
        {
            var listTest = populateList();

            foreach (var test in listTest)
            {
                cbcl.Items.Add(test);
            }
            // If more then 5 items, add a scroll bar to the dropdown.
            cbcl.MaxDropDownItems = 5;
            // Make the "Name" property the one to display
            cbcl.DisplayMember = "Name";
            cbcl.ValueSeparator = ", ";

        }

        private void buttonSurprise_Click(object sender, EventArgs e)
        {
            //list with results
            var listResult = new List<Test>();
            //list with strings
            var str = "";

            for (int i = 0; i < cbcl.Items.Count; i++)
            {
                if (cbcl.GetItemChecked(i))
                {
                    var test = (Test)cbcl.Items[i];
                    listResult.Add(test);
                    str = str + test.Name + ",";
                }
            }
            MessageBox.Show(str);
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ignore

        }

        private void cbcl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ignore
        }

    }
}

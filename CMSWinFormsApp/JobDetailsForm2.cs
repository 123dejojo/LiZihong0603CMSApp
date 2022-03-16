using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinFormsApp
{
    public partial class JobDetailsForm2 : Form
    {
        public JobDetailsForm2()
        {
            InitializeComponent();
        }

        private void tblJobDetailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tblJobDetailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.jobDetailsDataSet1);

        }

        private void JobDetailsForm2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'jobDetailsDataSet1.tblJobDetails' table. You can move, or remove it, as needed.
            this.tblJobDetailsTableAdapter.Fill(this.jobDetailsDataSet1.tblJobDetails);

        }

        private void balancingLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

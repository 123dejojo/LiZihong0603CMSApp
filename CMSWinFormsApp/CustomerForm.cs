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
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            errCustForm.SetError(textBox1, "");
            errCustForm.SetError(textBox2, "");
            errCustForm.SetError(textBox3, "");
            errCustForm.SetError(textBox4, "");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flag;
            flag = true;
            if(textBox1.Text == "")
            {
                errCustForm.SetError(textBox1, "Please Specify a Valid Car Number");
                flag = false;
            }
            else
            {
                errCustForm.SetError(textBox1, "");
            }

            if(textBox2.Text == "")
            {
                errCustForm.SetError(textBox2, "Please Specify a Valid Name");
                flag = false;
            }
            else
            {
                errCustForm.SetError(textBox2, "");
            }

            if(textBox3.Text == "")
            {
                errCustForm.SetError(textBox3, "Please Specify a Valid Address");
                flag = false;
            }
            else
            {
                errCustForm.SetError(textBox3, "");
            }

            if (textBox4.Text == "")
            {
                errCustForm.SetError(textBox4, "Please Specify a Valid Make");
                flag = false;
            }
            else
            {
                errCustForm.SetError(textBox4, "");
            }
            if (flag == true)
                return;
            else
            {
                //data base code
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BP_and_ERP_Project
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bP_PayrollDataSet3.Login' table. You can move, or remove it, as needed.
            this.loginTableAdapter.Fill(this.bP_PayrollDataSet3.Login);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

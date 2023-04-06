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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to perform this action?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)    //check conformation box
            {
                Form1 a = new Form1();
                this.Hide();
                a.Show();
            }
            else
            {
                MainPage b = new MainPage();
                this.Hide();
                b.Show();  // error ---> remove previous data
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            //this.Hide();
            em.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Payroll pay= new Payroll();
            pay.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Attendance att= new Attendance();   
            att.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Admincheck ad = new Admincheck();
            ad.ShowDialog();
        }
    }
}

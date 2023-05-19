using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;

namespace BP_and_ERP_Project
{
    public partial class Form1 : Form
    {

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-4BLCHTST\\SQLEXPRESS;Initial Catalog=BP_Payroll;Integrated Security=True");

        Thread th;

        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM Login WHERE Username ='" + textBox1.Text.Trim() + "' AND Password ='" + textBox2.Text.Trim() + "' ";
            SqlDataAdapter log = new SqlDataAdapter(sql,con); 
            DataTable dataTable= new DataTable();
            log.Fill(dataTable);

            

            if (dataTable.Rows.Count == 1)
            {
                timer1.Start();
                progressBar1.Show();
            }
            else if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please fill up all field");
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(35);
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                //MainPage a = new MainPage();
                //this.Hide();
                //a.Show();

                th = new Thread(OpeNewForm);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();


            }
        }

        private void OpeNewForm()
        {
            Application.Run(new MainPage());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

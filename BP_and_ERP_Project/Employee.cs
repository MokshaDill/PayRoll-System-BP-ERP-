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

namespace BP_and_ERP_Project
{
    public partial class Employee : Form
    {

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-4BLCHTST\\SQLEXPRESS;Initial Catalog=BP_Payroll;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();

        public Employee()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
           // cmd = new SqlCommand("INSERT INTO EmpData(Firstname, Lastname, Address, Gender, Status, Birthday, Tpnum, Honum, Position, Qualification) VALUES('"+textBox2.Text+"','"+textBox3.Text+"','"+richTextBox1.Text+"','"+comboBox1.Text+"','"+comboBox2.Text+"','"+textBox4+"','"+textBox7.Text+"','"+textBox9.Text+"','"+comboBox3.Text+"','"+richTextBox2.Text+ "')", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            con.Close();






            //else if (textBox1.Text == "" || textBox2.Text == "")
            //{
            //    MessageBox.Show("Please fill up all field");
            //}
            //else
            //{
            //    MessageBox.Show("Incorrect Username or Password");
            //}
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ////textBox1.Clear();
            //textBox2.Clear();
            //textBox3.Clear();
            //richTextBox1.Clear();
            ////richTextBox2.Clear();
            //comboBox1.ResetText();
            //comboBox2.ResetText();
            //comboBox3.ResetText();
            //textBox4.Clear();
            //textBox7.Clear();
            //textBox9.Clear();
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bP_PayrollDataSet.EmpData' table. You can move, or remove it, as needed.
            this.empDataTableAdapter.Fill(this.bP_PayrollDataSet.EmpData);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count > 1)
                {
                    if (dataGridView1.CurrentRow.Index == dataGridView1.Rows.Count - 1)
                    {
                        MessageBox.Show("Please Select Date");
                    }
                    else
                    {
                        string del = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                        con.Open();
                        cmd = new SqlCommand("DELETE FROM EmpData WHERE ID = '" + del + "'", con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Data deleted");
                        con.Close();

                        string query = "SELECT * FROM EmpData";
                        SqlDataAdapter da = new SqlDataAdapter(query, con);
                        DataSet ds = new DataSet();
                        da.Fill(ds, "Employee info");
                        dataGridView1.DataSource = ds;
                        dataGridView1.DataMember = "Employee info";
                        dataGridView1.DataSource = dataGridView1.DataSource;
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("No More Data");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }
    }
}

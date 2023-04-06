using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BP_and_ERP_Project
{
    public partial class Attendance : Form
    {

        SqlConnection con = new SqlConnection("Data Source=LAPTOP-4BLCHTST\\SQLEXPRESS;Initial Catalog=BP_Payroll;Integrated Security=True");


        public int idp;
        public Attendance()
        {
            InitializeComponent();
            UpdateTime();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bP_PayrollDataSet2.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter1.Fill(this.bP_PayrollDataSet2.Attendance);
            // TODO: This line of code loads data into the 'bP_PayrollDataSet1.Attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.bP_PayrollDataSet1.Attendance);
            // TODO: This line of code loads data into the 'bP_PayrollDataSet.EmpData' table. You can move, or remove it, as needed.
            this.empDataTableAdapter.Fill(this.bP_PayrollDataSet.EmpData);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = comboBox4.Text.ToString();
            idp= int.Parse(id);
            string firstname1 = textBox1.Text.ToString();
            string type = comboBox2.Text.ToString();
            string status = "Attend -->";

            DateTime dateTime= DateTime.Now;

            string sql = "SELECT Firstname FROM EmpData WHERE ID= " + idp + "";

            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                textBox1.Text = reader["Firstname"].ToString();
                firstname1 = reader["Firstname"].ToString();

            }
            con.Close();


            if (textBox1.Text == "" || comboBox2.Text == "" || comboBox4.Text == "")
            {
                MessageBox.Show("Please fill up all field");
            }
            else
            {
                {
                    SqlCommand cmd2 = new SqlCommand();

                    con.Open();
                    cmd2 = new SqlCommand("INSERT INTO Attendance(ID,Firstname, Type, Status, Date) VALUES('" + idp + "','" + firstname1 + "','" + type + "','" + status + "','" + dateTime + "')", con);
                    cmd2.ExecuteNonQuery();
                    MessageBox.Show("Saved");
                    con.Close();

                    this.Close();
                }

                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {
            UpdateTime();
        }

        private void UpdateTime()
        {
            label4.Text = "Current time: " + DateTime.Now.ToString("HH:mm:ss");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this. Close();
        }
    }
}

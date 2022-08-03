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

namespace Airlines_managment_system
{
    public partial class Form11 : Form
    {
        SqlDataAdapter adpt;
        DataTable dat;
        public Form11()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.blur_bokeh_dark_defocused_376533__1_;
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=US_BANGLA_AIRLINES;Integrated Security=True");

        private void button8_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        public void ShowData()
        {
            string s = "select * from Passenger ";
            adpt = new SqlDataAdapter(s, con);
            dat = new DataTable();
            adpt.Fill(dat);
            dataGridView1.DataSource = dat;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowData2();
        }
        public void ShowData2()
        {
            string s = "select * from Employee ";
            adpt = new SqlDataAdapter(s, con);
            dat = new DataTable();
            adpt.Fill(dat);
            dataGridView1.DataSource = dat;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowData3();
        }
        public void ShowData3()
        {
            string s = "select SUM(Salary) as Total_Summation_of_Salary from Employee ";
            adpt = new SqlDataAdapter(s, con);
            dat = new DataTable();
            adpt.Fill(dat);
            dataGridView1.DataSource = dat;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowData4();
        }
        public void ShowData4()
        {
            string s = "select AVG(Salary) as Total_Summation_of_Salary from Employee";
            adpt = new SqlDataAdapter(s, con);
            dat = new DataTable();
            adpt.Fill(dat);
            dataGridView1.DataSource = dat;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        public void ShowData5()
        {
            string s = "select AVG(Salary) as Total_Summation_of_Salary from Employee";
            adpt = new SqlDataAdapter(s, con);
            dat = new DataTable();
            adpt.Fill(dat);
            dataGridView1.DataSource = dat;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ShowData6();
        }
        public void ShowData6()
        {
            string s = "select * from Employee where Salary > '" + textBox2.Text + "'";
            adpt = new SqlDataAdapter(s, con);
            dat = new DataTable();
            adpt.Fill(dat);
            dataGridView1.DataSource = dat;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowData7();
        }
        public void ShowData7()
        {
            string s = "select * from Employee where Salary > (select salary from Employee where Emp_ID= '" + textBox1.Text + "')";
            adpt = new SqlDataAdapter(s, con);
            dat = new DataTable();
            adpt.Fill(dat);
            dataGridView1.DataSource = dat;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            con.Open();

            string p = "DELETE FROM Emp_user where Emp_ID ='" + textBox3.Text + "'";
            SqlDataAdapter sdb = new SqlDataAdapter(p, con);
            sdb.SelectCommand.ExecuteNonQuery();

            string s = "DELETE FROM Employee where Emp_ID ='" + textBox3.Text + "'";
            SqlDataAdapter sdc = new SqlDataAdapter(s, con);
            sdc.SelectCommand.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Employee has been deleted from the Database Successfully!.");
        }


    }
}

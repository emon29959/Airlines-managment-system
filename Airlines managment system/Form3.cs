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
    public partial class Form3 : Form
    {
        SqlDataAdapter adpt;
        DataTable dat;
        public Form3()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.emp_log;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 ss = new Form5();
            ss.Show();
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=US_BANGLA_AIRLINES;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Username and password connot be empty!.");
            }
            else
            {
                con.Open();
                string q = "select count(*) from Emp_user where username= '" + textBox1.Text.Trim() + "' and password = '" + textBox2.Text.Trim() + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(q, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    
                    Form6 ss = new Form6();
                    ss.Show();
                    ShowData();

                }
                else
                {
                    MessageBox.Show("Username and password are not matching!.Please reenter currectly or signup.");
                }
                con.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }
        public void ShowData()
        {
            string s = "SELECT e.Emp_ID as Your_ID,e.Emp_Name as Your_Name ,e.Gender as Your_Gender,e.PhoneNO,e.Salary FROM Employee e INNER JOIN Emp_user u ON e.Emp_ID=u.Emp_ID where username ='" + textBox1.Text + "'";
            adpt = new SqlDataAdapter(s, con);
            dat = new DataTable();
            adpt.Fill(dat);
            dataGridView1.DataSource = dat;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 ss = new Form6();
            ss.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}

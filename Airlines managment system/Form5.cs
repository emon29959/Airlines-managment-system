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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources._5ddbaa7df95aacf12e7ae5a5181d0fd7;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=US_BANGLA_AIRLINES;Integrated Security=True");


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Please fill all the boxes!.");
            }
            else
            {
                con.Open();
                string q = "insert into Employee (Emp_Name,Age,Salary,Gender,PhoneNO) values('" + textBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "','" + textBox6.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(q, con);
                sda.SelectCommand.ExecuteNonQuery();
                string p = "insert into Emp_user (password,username) values('" + textBox3.Text + "','" + textBox2.Text + "')";
                SqlDataAdapter sdb = new SqlDataAdapter(p, con);
                sdb.SelectCommand.ExecuteNonQuery(); 
                con.Close();
                MessageBox.Show("Signup completed.Now you can login!.");
                this.Hide();
                Form3 ss = new Form3();
                ss.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }
    }
}

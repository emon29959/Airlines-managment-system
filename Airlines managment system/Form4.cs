using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Airlines_managment_system
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources._137672_nature_path_blurred_748x421;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=US_BANGLA_AIRLINES;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Please fill all the boxes!.");
            }
            else
            {
                con.Open();
                string q = "insert into Passenger (P_Name,Country,P_Address,gender,PhoneNO,Email) values('" + textBox1.Text + "','" + textBox3.Text + "','" + textBox6.Text + "','" + comboBox1.Text + "','" + textBox2.Text + "','" + textBox7.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(q, con);
                sda.SelectCommand.ExecuteNonQuery();
                string p = "insert into Psngr_user (password,username) values('" + textBox5.Text + "','" + textBox4.Text + "')";
                SqlDataAdapter sdb = new SqlDataAdapter(p, con);
                sdb.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Signup completed.Now you can login!.");
                this.Hide();
                Form2 ss = new Form2();
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

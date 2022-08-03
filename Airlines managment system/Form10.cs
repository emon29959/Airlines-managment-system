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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.emp_log;
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=US_BANGLA_AIRLINES;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || comboBox1.Text == "")
            {
                MessageBox.Show("Please fill all the boxes!.");
            }
            else
            {
                con.Open();
                string q = "insert into booking values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + comboBox1.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(q, con);
                sda.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Booking request has been sent!.Please wait for confirmation");
                this.Hide();
                Form2 ss = new Form2();
                ss.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2();
            ss.Show();
        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
    }
}

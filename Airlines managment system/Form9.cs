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
    public partial class Form9 : Form
    {
        SqlDataAdapter adpt;
        DataTable dat;
        public Form9()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.landscape_photography_of_mountains_covered_in_snow_691668;
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
                MessageBox.Show("Passenger has been added to the database!.");
            }
        }
        public void ShowData()
        {
            string s = "select * from Passenger ";
            adpt = new SqlDataAdapter(s, con);
            dat = new DataTable();
            adpt.Fill(dat);
            dataGridView1.DataSource = dat;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 ss = new Form6();
            ss.Show();
        }

        private void Form9_Load(object sender, EventArgs e)
        {

        }
    }
}

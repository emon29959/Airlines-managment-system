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
    public partial class Form7 : Form
    {
        SqlDataAdapter adpt;
        DataTable dat;
        public Form7()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources._137672_nature_path_blurred_748x421;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 ss = new Form6();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=US_BANGLA_AIRLINES;Integrated Security=True");

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 ss = new Form6();
            ss.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = " UPDATE Passenger SET P_Address = '" + textBox4.Text + "' WHERE P_ID = '" + textBox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(q, con);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Updated!");
            con.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = " UPDATE Passenger SET P_Name = '" + textBox2.Text + "' WHERE P_ID = '" + textBox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(q, con);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Updated!");
            con.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = " UPDATE Passenger SET Country = '" + textBox3.Text + "' WHERE P_ID = '" + textBox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(q, con);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Updated!");
            con.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = " UPDATE Passenger SET gender = '" + textBox5.Text + "' WHERE P_ID = '" + textBox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(q, con);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Updated!");
            con.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = " UPDATE Passenger SET PhoneNO = '" + textBox6.Text + "' WHERE P_ID = '" + textBox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(q, con);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Updated!");
            con.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            con.Open();
            string q = " UPDATE Passenger SET Email = '" + textBox7.Text + "' WHERE P_ID = '" + textBox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(q, con);
            sda.SelectCommand.ExecuteNonQuery();
            MessageBox.Show("Updated!");
            con.Close();
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}

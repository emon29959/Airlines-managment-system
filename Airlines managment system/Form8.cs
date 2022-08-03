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
    public partial class Form8 : Form
    {
        SqlDataAdapter adpt;
        DataTable dat;
        public Form8()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.brZN5O;
        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=US_BANGLA_AIRLINES;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            ShowData();
        }
        public void ShowData()
        {
            string s = "select * from Passenger where P_ID = '" + textBox1.Text + "' ";
            adpt = new SqlDataAdapter(s, con);
            dat = new DataTable();
            adpt.Fill(dat);
            dataGridView1.DataSource = dat;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "")
            {
                MessageBox.Show("Please fill all the boxes!.");
            }
            else
            {
                con.Open();
                string q = "insert into Tickets values('" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "','" + textBox9.Text + "')";
                SqlDataAdapter sda = new SqlDataAdapter(q, con);
                sda.SelectCommand.ExecuteNonQuery();

                string s = "delete from booking where P_ID= '" + textBox4.Text + "'";
                SqlDataAdapter sda1 = new SqlDataAdapter(s, con);
                sda1.SelectCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Ticket Has Been Made For ID: '"+ textBox4.Text +"'!.");
                
            }
        }
        public void ShowData2()
        {
            string s = " SELECT p.P_ID as Your_ID,p.P_Name as Your_Name ,p.Country as Your_Country,p.P_Address as Your_P_Address,p.gender as Your_Gender,p.PhoneNO,p.Email,t.Airlines_company,t.Airplane_Id,t.Amount,t.Depr_date,t.Depr_Hr,t.Destination,t.Flight_No,t.ticket_num FROM Passenger p INNER JOIN Tickets t ON p.P_ID=t.P_ID where p.P_ID= '" + textBox1.Text.Trim() + "' ";
            adpt = new SqlDataAdapter(s, con);
            dat = new DataTable();
            adpt.Fill(dat);
            dataGridView1.DataSource = dat;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowData2();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 ss = new Form6();
            ss.Show();
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }
    }
}

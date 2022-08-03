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
    public partial class Form2 : Form
    {
        SqlDataAdapter adpt;
        DataTable dat;
        public Form2()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.wp2001722;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 ss = new Form4();
            ss.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
                string q = "select count(*) from Psngr_user where username= '" + textBox1.Text.Trim() + "' and password = '" + textBox2.Text.Trim() + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(q, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
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
            string s = "SELECT p.P_ID as Your_ID,p.P_Name as Your_Name ,p.Country as Your_Country,p.P_Address as Your_P_Address,p.gender as Your_Gender,p.PhoneNO,p.Email FROM Passenger p INNER JOIN Psngr_user u ON p.P_ID=u.P_ID where username = '" + textBox1.Text + "' ";
            adpt = new SqlDataAdapter(s,con );
            dat= new DataTable();
            adpt.Fill(dat);
            dataGridView1.DataSource= dat ;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ShowData2();
        }
        public void ShowData2()
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Login First!.");
            }
            else
            {
                string s = " SELECT p.P_ID as Your_ID,p.P_Name as Your_Name ,p.Country as Your_Country,p.P_Address as Your_P_Address,p.gender as Your_Gender,p.PhoneNO,p.Email,t.Airlines_company,t.Airplane_Id,t.Amount,t.Depr_date,t.Depr_Hr,t.Destination,t.Flight_No,t.ticket_num FROM Passenger p INNER JOIN Tickets t ON p.P_ID=t.P_ID inner join Psngr_user ps on ps.P_ID=p.P_ID where ps.username='" + textBox1.Text + "' and ps.password = '" + textBox2.Text + "' ";
                adpt = new SqlDataAdapter(s, con);
                dat = new DataTable();
                adpt.Fill(dat);
                dataGridView1.DataSource = dat;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Please Login First!.");
            }
            else
            {
                this.Hide();
                Form10 ss = new Form10();
                ss.Show();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Load_1(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form6 : Form
    {
        SqlDataAdapter adpt;
        DataTable dat;
        public Form6()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.reswp2001722;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 ss = new Form2();
            ss.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        SqlConnection con = new SqlConnection(@"Data Source=localhost;Initial Catalog=US_BANGLA_AIRLINES;Integrated Security=True");

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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form7 ss = new Form7();
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 ss = new Form8();
            ss.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowData2();
        }
        public void ShowData2()
        {
            string s = "select Count(*) AS TOTAL_PASSENGERS from Passenger ";
            adpt = new SqlDataAdapter(s, con);
            dat = new DataTable();
            adpt.Fill(dat);
            dataGridView1.DataSource = dat;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {
            ShowData2();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 ss = new Form9();
            ss.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ShowData3();
        }
        public void ShowData3()
        {
            string s = "select * from booking ";
            adpt = new SqlDataAdapter(s, con);
            dat = new DataTable();
            adpt.Fill(dat);
            dataGridView1.DataSource = dat;
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            con.Open();
           
            string p = "DELETE FROM Psngr_user where P_ID ='" + textBox1.Text + "'";
            SqlDataAdapter sdb = new SqlDataAdapter(p, con);
            sdb.SelectCommand.ExecuteNonQuery();

            string s = "DELETE FROM Tickets where P_ID ='" + textBox1.Text + "'";
            SqlDataAdapter sdc = new SqlDataAdapter(s, con);
            sdc.SelectCommand.ExecuteNonQuery();

            string t = "DELETE FROM booking where P_ID ='" + textBox1.Text + "'";
            SqlDataAdapter sdd = new SqlDataAdapter(t, con);
            sdd.SelectCommand.ExecuteNonQuery();

            string q = "DELETE FROM Passenger where P_ID ='" + textBox1.Text + "'";
            SqlDataAdapter sda = new SqlDataAdapter(q, con);
            sda.SelectCommand.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Passenger has been deleted from the Database Successfully!.");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ShowData4();
        }
        public void ShowData4()
        {
            con.Open();
            string s = "select Tickets.P_ID as Passenger_ID, Count(Tickets.P_ID) as Total_Tickets,Passenger.P_Name,Passenger.PhoneNO from Tickets inner join Passenger on Passenger.P_ID = Tickets.P_ID group by Tickets.P_ID,Passenger.P_Name,Passenger.PhoneNO having Count(Tickets.P_ID) > '" + textBox2.Text + "'";
            adpt = new SqlDataAdapter(s, con);
            dat = new DataTable();
            adpt.Fill(dat);
            dataGridView1.DataSource = dat;
            con.Close();
            
        }
    }
}

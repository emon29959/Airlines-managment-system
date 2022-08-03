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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.landscape_photography_of_mountains_covered_in_snow_691668;
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
                string q = "select count(*) from admin where username= '" + textBox1.Text.Trim() + "' and password = '" + textBox2.Text.Trim() + "' ";
                SqlDataAdapter sda = new SqlDataAdapter(q, con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    this.Hide();
                    Form11 ss = new Form11();
                    ss.Show();
                }
                else
                {
                    MessageBox.Show("Username and password are not matching!.Please reenter currectly.");
                }
                con.Close();
            }
        }

        private void Form12_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }
    }
}

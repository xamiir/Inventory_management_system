using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string ConectionString = "Data Source=DESKTOP-21OPG07;Initial Catalog=Users;Integrated Security=True";
            //string userName = User.Text;
           // string Password = textBox1.Text
           

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "Data Source=DESKTOP-21OPG07;Initial Catalog=Users;Integrated Security=True";
            con.Open();
            string userid =User.Text;
            string password = textBox1.Text;
            SqlCommand cmd = new SqlCommand("select userName,password from Users where userName='" + User.Text + "'and password='" +textBox1.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count ==1)
            {
                MessageBox.Show("Login sucess Welcome to Homepage");
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();
        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
       
           

        {    this.Hide();
            register register = new register();
           register.ShowDialog();
            this.Close();
        }
    }
}

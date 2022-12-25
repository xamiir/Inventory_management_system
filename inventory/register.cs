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
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace inventory
{
    public partial class register : Form
    {
        SqlCommand cmd;
        SqlConnection cn;
        SqlDataReader dr;
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {




        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registerbnt_Click(object sender, EventArgs e)
        {
            string connection = @"Data Source=DESKTOP-21OPG07;Initial Catalog=Users;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection);
            try
            {
                if (User.Text == string.Empty || userNametxt.Text == string.Empty || passwordtxt.Text == string.Empty || confptxt.Text == string.Empty || comboBox1.Text == string.Empty || sQuestiontxt.Text == string.Empty || sAnswertxt.Text == string.Empty || rDatetxt.Text == string.Empty)
                {
                    MessageBox.Show("fields is empty");




                }
                else if (passwordtxt.Text.Length < 6)
                {
                    MessageBox.Show("length passwords is less then 6");
                }
                else if (passwordtxt.Text != confptxt.Text)
                {
                    MessageBox.Show(" password and confirmPassword are not same ");
                }
               
                    
                else
                {

                    string query = "Insert into AddUsers(fullName, userName, passwordt, confirmPassword, userType, sQuestion, sAnswer, rDate) Values('" + User.Text + "','" + userNametxt.Text + "','" + passwordtxt.Text + "','" + confptxt.Text + "','" + comboBox1.Text + "','" + sQuestiontxt.Text + "','" + sAnswertxt.Text + "','" + rDatetxt.Text + "')";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    con.Open();
                    da.SelectCommand.ExecuteNonQuery();
                    MessageBox.Show("Account created successfully..");
                }
                    
                    
                



               
                    }
            catch
            {
                MessageBox.Show("Error occured...");
            }
            finally
            {
                con.Close();
            }
        }
     

        private void button1_Click_1(object sender, EventArgs e)
        {
            User.Text = "";
            userNametxt.Text = "";
            passwordtxt.Text = "";
            confptxt.Text = "";
            comboBox1.Text = "";
            sQuestiontxt.Text = "";
            sAnswertxt.Text = "";
            rDatetxt.Text = "";
            User.Focus();
            
            

            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();
            this.Close();
        }
    }
}

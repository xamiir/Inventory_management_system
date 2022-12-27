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
            try {
                string userName = User.Text;
                string passwordt = textBox1.Text;

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-21OPG07;Initial Catalog=Users;Integrated Security=True");    
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM AddUsers WHERE userName='" + userName + "' AND passwordt='" + passwordt + "'", con);
                
                DataTable dt = new DataTable();   
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {

                    //MessageBox.Show("welcome home page");
                   
                    this.Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.ShowDialog();
                    this.Close();

                }
                else
                    MessageBox.Show("Invalid username or password");
            
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Exception: " + ex.Message);
            }

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

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

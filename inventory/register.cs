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
        public register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            String ConnectionString = "Data Source=DESKTOP-21OPG07;Initial Catalog=Users;Integrated Security=True ";

            SqlConnection conn = new SqlConnection(ConnectionString);
            conn.Open();
            string UserName = User.Text;
            string password = textBox1.Text;

            String Query = "insert into Users(userName,password) values( '" + UserName + " ','" + password + "')";
            SqlCommand cmd = new SqlCommand(Query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            
           

            if (User.Text == "" || textBox1.Text == "")
            {
                MessageBox.Show("username or password is empty");
            }
            else if (User.Text != "" || textBox1.Text != "")
            {
                MessageBox.Show("data that has been saved");
                this.Hide();
                Form1 form = new Form1();
                form.ShowDialog();
                this.Close();
            }

          /*  else
            {
                this.Hide();
                Form1 form = new Form1();
                form.ShowDialog();
                this.Close();


            }
*/





        }

        private void User_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

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

namespace inventory
{
   
    public partial class Oders : Form
    {
        public Oders()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void label2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().ShowDialog();
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

            this.Hide();
            Form1 login = new Form1();
            login.ShowDialog();
            this.Close();

        }

        private void label3_Click(object sender, EventArgs e)
        {

            this.Hide();
            Products items = new Products();
            items.ShowDialog();
            this.Close();
        }

        private void Oders_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            load_Data();
        }
        private void load_Data()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-21OPG07;Initial Catalog=MyDB;Integrated Security=True");
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Addproducts", conn);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
}

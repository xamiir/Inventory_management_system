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
    public partial class Products : Form
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-21OPG07;Initial Catalog=MyDB;Integrated Security=True");
        
        public Products()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            
            
               

            if (itemNametxt.Text == "" || categorytxt.Text == "" || quantity.Text == "" || price.Text == "" )
            {
                MessageBox.Show("please fill the cell first");
            }
            else
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("insert into Addproducts(itemName,category,quantity,price)values('" + itemtxt.Text + "','" + categorytxt.Text + "','" + quantitytxt.Text.ToString() + "','" + pricetxt.Text.ToString() +  "')", conn);

                sda.SelectCommand.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("data entered succesfully. . . .");
              

            }

        }

        private void veiwtxt_Click(object sender, EventArgs e)
        {
            load_Data();
        }
        private void load_Data()
        {
            try
            {
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select * from Addproducts", conn);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView2.DataSource = data;
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Exception: " + ex.Message);
            }
        }

        private void Products_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deletebnt_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-21OPG07;Initial Catalog=MyDB;Integrated Security=True");
            string query = "update Addproducts set itemName = @itemName, category = @category, quantity = @quantity, price = @price where price = @price";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@itemName",itemtxt.Text );
            cmd.Parameters.AddWithValue("@category", categorytxt.Text);
            cmd.Parameters.AddWithValue("@quantity", quantitytxt.Text);
            cmd.Parameters.AddWithValue("@price", pricetxt.Text);
            con.Open();

            int a = cmd.ExecuteNonQuery();
            if (a > 0)
            {
                MessageBox.Show("Updated Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            else
            {
                MessageBox.Show("Updation Failed !!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            con.Close();
            
        }

        private void itemNametxt_Click(object sender, EventArgs e)
        {

        }

        private void itemtxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchingbtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-21OPG07;Initial Catalog=MyDB;Integrated Security=True");
            string query = "select * from Addproducts where itemName like @itemName + '%'";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            if (itemtxt.Text == "")
            {
                MessageBox.Show("Enter itemName");
            }
            else
            {
                sda.SelectCommand.Parameters.AddWithValue("@itemName", itemtxt.Text.Trim());
                DataTable data = new DataTable();
                sda.Fill(data);
                if (data.Rows.Count > 0)
                {
                    dataGridView2.DataSource = data;
                }
                else
                {
                    MessageBox.Show("No Rows Found !!!");
                    dataGridView2.DataSource = null;
                }
            }
           
           
        }
    }
}
    


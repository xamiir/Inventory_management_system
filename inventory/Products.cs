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


            try
            {


                if (IdTxt.Text == "" || itemNametxt.Text == "" || categorytxt.Text == "" || quantitytxt.Text == "" || pricetxt.Text == "")
                {
                    MessageBox.Show("please fill the cell first");
                }
                else
                {
                    double price = double.Parse(pricetxt.Text.ToString());
                    int quant = int.Parse(quantitytxt.Text.ToString());
                    double amount = price * quant;



                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-21OPG07;Initial Catalog=MyDB;Integrated Security=True");

                    string query2 = "select * from Addproducts where id = @id";
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    cmd2.Parameters.AddWithValue("@id", IdTxt.Text);
                    con.Open();
                    SqlDataReader dr = cmd2.ExecuteReader();
                    if (dr.HasRows == true)
                    {
                        MessageBox.Show(IdTxt.Text + " ID already Exists !!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        con.Close();
                    }
                    else
                    {
                        conn.Open();
                        SqlDataAdapter sda = new SqlDataAdapter("insert into Addproducts(id,itemName,category,quantity,price,Amout)values('" + IdTxt.Text.ToString() + "','" + itemtxt.Text + "','" + categorytxt.Text + "','" + quantitytxt.Text.ToString() + "','" + pricetxt.Text.ToString() + "','"+amount+"')", conn);
                        sda.SelectCommand.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("data entered succesfully. . . .");
                       // con.Close();
                    }
                 
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Exception: " + ex.Message);
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
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-21OPG07;Initial Catalog=MyDB;Integrated Security=True");

                if (IdTxt.Text == "" || itemNametxt.Text == "" || categorytxt.Text == "" || quantitytxt.Text == "" || pricetxt.Text == "")
                {
                    MessageBox.Show("please fill the cell first");
                }
                else
                {
                    string query = "update Addproducts set id = @id , itemName = @itemName, category = @category, quantity = @quantity, price = @price where id = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@id", IdTxt.Text);
                    cmd.Parameters.AddWithValue("@itemName", itemtxt.Text);
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


            }
            catch (Exception ex)
            {

                MessageBox.Show("Exception: " + ex.Message);
            }
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
            if (searchingtxt.Text == "")
            {
                MessageBox.Show("Enter itemName");
            }
            else
            {
                sda.SelectCommand.Parameters.AddWithValue("@itemName", searchingtxt.Text.Trim());
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Deletebnt_Click_1(object sender, EventArgs e)
        {

            if (IdTxt.Text == "")
            {
                MessageBox.Show("please fill the cell first");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-21OPG07;Initial Catalog=MyDB;Integrated Security=True");
                    string query = "delete from Addproducts where id = @id";
                    string orderQuery = "DELETE Orders where product = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlCommand orderCMD = new SqlCommand(orderQuery, con);
                    cmd.Parameters.AddWithValue("@id", IdTxt.Text);
                    orderCMD.Parameters.AddWithValue("@id", IdTxt.Text);

                    con.Open();
                    orderCMD.ExecuteNonQuery();
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("Deleted Successfully !!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("Deletion Failed !!", "Failure", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();

                } catch (Exception ex)
                {
                    MessageBox.Show("Exception", ex.Message);
                }
            }
        }

        private void IdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pricetxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Amouttxt_TextChanged(object sender, EventArgs e)
        {

            // pricetxt.Text = double.Parse(pricetxt.Text).ToString();
          
            






        }
    }
}

    


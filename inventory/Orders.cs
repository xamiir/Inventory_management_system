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
   
    public partial class Orders : Form
    {
        public Orders()
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
             load_Data();
             if (txtProductId.Text == "")
            {
                txtQuantity.ReadOnly = true;
                lblCheckQuantity.Visible = true;
                lblCheckQuantity.ForeColor = Color.Red;
                lblCheckQuantity.Text = "Product columns is empty, so you can't add quantity";
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string price = txtPrice.Text;
            string product = txtProductId.Text;
            string quantity = txtQuantity.Text;

            if (price.Length == 0 || product.Length == 0 || quantity.Length == 0)
            {
                MessageBox.Show("All fields are required", "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }   else
            {
                CreateOrder(price, product, quantity);
                HandleReset();
            }
           

        }
        private void HandleReset()
        {
            txtPrice.Clear();
            txtProductId.Clear();
            txtQuantity.Clear() ;
            comboProduct.Text = "";
        }
        private void CreateOrder(string price, string product, string quantity)
        {
            double totalPrice;
            double.TryParse(price.ToString(), out totalPrice);
            int quant;
            int.TryParse(quantity.ToString(), out quant);

            double amount = totalPrice * quant;
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-21OPG07;Initial Catalog=MyDB;Integrated Security=True");
                SqlCommand commandString = new SqlCommand("EXEC sp_createOrder @product = '"+product+"', @quantity = '"+ quantity +"', @price = '"+ amount + "'", conn);
                conn.Open();
                commandString.ExecuteNonQuery();
                MessageBox.Show("Order is created successfully");
                conn.Close();
               
            } catch(Exception ex)
            {
                MessageBox.Show("Exception", ex.Message);
            }
        }
    
        private void load_Data()
        {
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-21OPG07;Initial Catalog=MyDB;Integrated Security=True");
                SqlCommand commandString = new SqlCommand("select id,itemName,price from Addproducts", conn);
                conn.Open();
              

                SqlDataAdapter sda = new SqlDataAdapter("select * from Addproducts", conn);
                DataTable data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;

                SqlDataReader reader = commandString.ExecuteReader();
                while (reader.Read())
                {
                   
                    comboProduct.Items.Add(reader[1].ToString());
                   
                }


                reader.Close();
                conn.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Exception: " + ex.Message);
            }
        }
        public void getItemByName(string name)
        {
        
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-21OPG07;Initial Catalog=MyDB;Integrated Security=True");
                SqlCommand commandString = new SqlCommand("select id,price from Addproducts where itemName = '" + name + "'", conn);
                conn.Open();

                SqlDataReader reader = commandString.ExecuteReader();
                while (reader.Read())
                {
                    txtProductId.Text = reader[0].ToString();
                    txtPrice.Text = reader[1].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
           
        }

        private void comboProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  MessageBox.Show(comboProduct.SelectedItem.ToString());
          getItemByName(comboProduct.SelectedItem.ToString());
            if (txtProductId.Text != "")
            {
                txtQuantity.ReadOnly = false;
                lblCheckQuantity.Visible = false;
            }
          
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            string quantity = txtQuantity.Text;
            string productId = txtProductId.Text;
          
            try
           
                {
                    SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-21OPG07;Initial Catalog=MyDB;Integrated Security=True");
                    SqlCommand commandString = new SqlCommand("select id,quantity from Addproducts where quantity < '" + quantity.ToString() + "' and id = '"+productId+"'", conn);
                    conn.Open();

                    SqlDataReader reader = commandString.ExecuteReader();
                if (reader.Read())
                {
                    lblCheckQuantity.Visible = true;
                    lblCheckQuantity.Text = "Out of stock";
                    lblCheckQuantity.ForeColor = Color.Red;
                    button1.Enabled = false;
                }
                else
                {
                    button1.Enabled = true;
                    lblCheckQuantity.Visible = false;
                }
            
                    } catch(Exception ex)
                {
                    MessageBox.Show("Exception", ex.Message);
                }
            

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

      

        private void label6_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            new Orders().ShowDialog();
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
            Products items =new Products();
            items.ShowDialog();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DL;
using BL;
namespace Sign_In.UI
{
    public partial class LowQuantityProducts : Form
    {
        public LowQuantityProducts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            Hide();
        }

        private void LowQuantityProducts_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = LowQuantityProductList();
            dataGridView1.Columns["MinimumQuantity"].Visible = false;

        }
        private List<Product> LowQuantityProductList()
        {
            List<Product> products = new List<Product>();
            foreach (Product p in ProductDL.products)
            {
                if (p.getMinimumQuantity() >= p.getAvailableQuantity())
                {
                    products.Add(p);

                }
            }
            return products;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

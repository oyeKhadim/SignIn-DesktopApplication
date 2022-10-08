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
    public partial class AdminMenu : Form
    {
        public AdminMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LowQuantityProducts lowQuantityProducts = new LowQuantityProducts();
            lowQuantityProducts.Show();
            Hide();
        }

        private void lblAdminMenu_Click(object sender, EventArgs e)
        {

        }

        private void btnBuyProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
            this.Hide();
        }

        private void btnAllProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            ViewProduct viewProducts = new ViewProduct();
            viewProducts.Show();
            //viewAllProducts();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExpensiveProduct expensiveProduct=new ExpensiveProduct();
            expensiveProduct.Show();
            Hide();

           //displayProduct(product);
        }

        private void btnGenereteInvoice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tax : " + ProductDL.totalTax());

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ProductDL.storeProducts();
            Hide();
            SignIN signIN=new SignIN();
            signIN.Show();
        }
    }
}

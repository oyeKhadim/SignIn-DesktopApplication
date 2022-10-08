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
    public partial class UserMenu : Form
    {
        public UserMenu()
        {
            InitializeComponent();
        }

        private void btnAllProducts_Click(object sender, EventArgs e)
        {
            
            ViewProductsUser viewProducts = new ViewProductsUser();
            viewProducts.Show();
            this.Hide();
        }

        private void btnBuyProduct_Click(object sender, EventArgs e)
        {
            BuyProduct buyProduct=new BuyProduct();
            buyProduct.Show();
            Hide();
        }
        

        private void btnGenereteInvoice_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Total Price : " + Program.customer.price());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ProductDL.storeProducts();
            CustomerDL.storeCustomer();
            Hide();
            SignIN signIN = new SignIN();
            signIN.Show();
        }
    }
}

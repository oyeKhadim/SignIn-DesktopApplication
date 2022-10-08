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
    public partial class AddProduct : Form
    {
        public AddProduct()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = addProduct();
            if(product != null)
            {

            ProductDL.addProductIntoList(product);
            ProductDL.storeProducts();
                MessageBox.Show("Product Added.");
                clearData();
            }
            else
            {
                MessageBox.Show("Please Fill All Fields");
            }
        }
        private void clearData()
        {
            txtName.Text = "";
            rbtnOther.Checked=true;
            txtPrice.Text = "";
            txtAvailableQuantity.Text = "";
            txtThresholdQuantity.Text = "";
        }
        private Product addProduct()
        {
            string name = txtName.Text;
            string catagory = null;
            if (rbtnGrocery.Checked)
            {
                catagory = "Groceery";
            }
            else if (rbtnFruit.Checked)
            {
                catagory = "Fruit";
            }
            else
            {
                catagory = "Others";
            }

            if (name != null && txtPrice.Text != "" && txtAvailableQuantity.Text != "" &&txtThresholdQuantity.Text!="")
            {
                int price = int.Parse(txtPrice.Text);
                int availableQuantity = int.Parse(txtAvailableQuantity.Text);
                int minimumQuantity = int.Parse(txtThresholdQuantity.Text);
                Product product = new Product(name, catagory, price, availableQuantity, minimumQuantity);
                return product;
            }
            return null;
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtAvailableQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtThresholdQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

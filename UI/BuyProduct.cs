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
    public partial class BuyProduct : Form
    {
        public BuyProduct()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {

                row.Selected = false;


            }
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(searchValue))
                {
                    row.Selected = true;
                    break;
                }
            }
        }

        private void BuyProduct_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ProductDL.products;
            dataGridView1.Columns["MinimumQuantity"].Visible = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedProduct = dataGridView1.SelectedRows[0].DataBoundItem as Product;
                textBox2.Text = selectedProduct.Name;
                textBox3.Text = selectedProduct.Price.ToString();
                textBox4.Text = selectedProduct.AvailableQuantity.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                var selectedProduct = dataGridView1.SelectedRows[0].DataBoundItem as Product;
                textBox2.Text = selectedProduct.Name;
                textBox3.Text = selectedProduct.Price.ToString();
                textBox4.Text = selectedProduct.AvailableQuantity.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (isRowSelected())
            {

                var selectedProduct = dataGridView1.SelectedRows[0].DataBoundItem as Product;
                textBox2.Text = selectedProduct.Name;
                textBox3.Text = selectedProduct.Price.ToString();
                textBox4.Text = selectedProduct.AvailableQuantity.ToString();
            }


        }
        private bool isRowSelected()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Selected == true)
                {

                    return true;
                }
            }
            return false;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == ""|| textBox2.Text == "")
            {
                MessageBox.Show("Please Fill All Fields");
            }
            else
            {

                int quantity = int.Parse(textBox5.Text);
                Product selectedProduct = null;
                if (isRowSelected())
                {
                    selectedProduct = dataGridView1.SelectedRows[0].DataBoundItem as Product;
                }
                if (quantity <= selectedProduct.AvailableQuantity)
                {
                    selectedProduct.AvailableQuantity -= quantity;
                    purchasedProducts purchasedProduct = new purchasedProducts(selectedProduct.Name, quantity);
                    Program.customer.addToList(purchasedProduct);
                    CustomerDL.storeCustomer();
                    MessageBox.Show("You Product has been added To Your cart.");
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";

                }
                else
                {
                    MessageBox.Show("Limited Stock.");
                }
                textBox5.Text = "";
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    row.Selected = false;


                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserMenu userMenu = new UserMenu();
            userMenu.Show();
            Hide();
        }
    }
}

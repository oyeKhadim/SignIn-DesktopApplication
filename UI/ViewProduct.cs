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
    public partial class ViewProduct : Form
    {
        public ViewProduct()
        {
            InitializeComponent();
        }
        private void ViewProduct_Load(object sender, EventArgs e)
        {


            dataGridView1.DataSource =ProductDL.products;
            dataGridView1.Columns["MinimumQuantity"].Visible = false;
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            Hide();
        }
    }
    }


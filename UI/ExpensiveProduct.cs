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
    public partial class ExpensiveProduct : Form
    {
        public ExpensiveProduct()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminMenu adminMenu = new AdminMenu();
            adminMenu.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ExpensiveProduct_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource= ProductDL.highPriceProduct();
           dataGridView1.Columns["MinimumQuantity"].Visible = false;
            for(int i = 1; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Visible=false;
            }

        }
    }
}

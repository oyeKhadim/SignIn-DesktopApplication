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
namespace Sign_In.UI
{
    public partial class ViewProductsUser : Form
    {
        public ViewProductsUser()
        {
            InitializeComponent();
        }

        private void ViewProductsUser_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = ProductDL.products;
            dataGridView1.Columns["MinimumQuantity"].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserMenu userMenu=new UserMenu();
            userMenu.Show();
            Hide();
        }
    }
}

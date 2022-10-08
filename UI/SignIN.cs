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
using Sign_In.UI;
namespace Sign_In
{
    public partial class SignIN : Form
    {

        public SignIN()
        {
            InitializeComponent();
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
        }

        private void mtxtPassword_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Visible = false;
        }

        private void txtUserName_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "Username")
            {
                txtUserName.Text = "";
            }
        }

        private void mtxtPassword_Click(object sender, EventArgs e)
        {
            if (mtxtPassword.Text == "Password")
            {
                mtxtPassword.Text = "";
            }
        }
        private void btnSignIN_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string password = mtxtPassword.Text;
            if (userName != "" && password != "")
            {

                int found = MUserDL.signIn(userName, password);
                if (found == -1)
                {
                    MessageBox.Show("User Not Found");
                }
                else
                {
                    MessageBox.Show("User Found");
                    this.Hide();

                    if (MUserDL.users[found].getRole() == "Admin")
                    {
                        AdminMenu adminMenu=new AdminMenu();
                        adminMenu.Show();
                    }
                    else
                    {
                        Customer customer = CustomerDL.checkCustomer(MUserDL.users[found]);
                        if (customer == null)
                        {
                            customer = new Customer();
                            customer.id = MUserDL.users[found];
                            CustomerDL.addToList(customer);
                        }
                        else
                        {
                            customer.id = MUserDL.users[found];
                        }
                        Program.customer=customer;
                        UserMenu userMenu=new UserMenu();
                        userMenu.Show();
                    }

                    }
            }
            else
            {
                MessageBox.Show("Please Fill all Fields To Continue");

            }
            clearLabels();

        }
        private void clearLabels()
        {
            txtUserName.Text = "";
            mtxtPassword.Text = "";

        }
    }
}

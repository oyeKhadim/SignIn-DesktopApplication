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
namespace Sign_In
{
    public partial class SignUP : Form
    {
        public SignUP()
        {
            InitializeComponent();
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



        private void btnSignUP_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = mtxtPassword.Text;
            string role = null;
            if (rbtnAdmin.Checked)
            {
                role = "Admin";
            }
            else if (rbtnUser.Checked)
            {
                role = "User";
            }
            if (username != "" && password != "" && role != null)
            {
                if (MUserDL.isUserExists(username))
                {
                    MessageBox.Show("User Already Exists With this Username.");
                }
                else
                {
                    MUserDL.signUp(username, password, role);
                    MessageBox.Show("User Created Successfully");
                }
                clearLabels();
            }
            else
            {
                MessageBox.Show("Please Fill All Fields");
            }
        }
        private void clearLabels()
        {
            txtUserName.Text = "";
            mtxtPassword.Text = "";
            rbtnAdmin.Checked = false;
            rbtnUser.Checked = false;
        }

       
    }
}

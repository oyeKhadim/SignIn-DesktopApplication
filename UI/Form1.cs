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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SignIN signIN = new SignIN();
            signIN.Show();
            this.Visible = false;
        }

        private void btnSignIN_Click(object sender, EventArgs e)
        {
            SignUP signUP = new SignUP();
            signUP.Show();
            this.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

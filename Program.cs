using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DL;
using BL;
using Sign_In.UI;

namespace Sign_In
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Customer customer = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string path = "passwords.txt";
            string path1 = "Products.txt";
            string path2 = "Customer.txt";

            
            
            if ( ProductDL.loadProducts(path1) && MUserDL.loadUsers(path)&& CustomerDL.loadCustomer(path2))
            {
                MessageBox.Show("Data Loaded");
            }
            else
            {
                MessageBox.Show("Data Loading Failed");
            }
       //     MessageBox.Show(MUserDL.users[0].getUserName()+" "+ MUserDL.users[0].getPassword());
            Application.Run(new Form1());
        }

    }
}

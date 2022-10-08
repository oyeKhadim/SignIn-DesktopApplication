using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
namespace DL
{
    internal class CustomerDL
    {
        public static List<Customer> customers = new List<Customer>();
        public static void addToList(Customer customer)
        {
            customers.Add(customer);
        }
        public static Customer checkCustomer(MUser user)
        {
            foreach (Customer customer in customers)
            {
                if (customer.id.getUserName() == user.getUserName() && customer.id.getPassword() == user.getPassword() && customer.id.getRole() == user.getRole())
                {
                    return customer;
                }
            }
            return null;
        }
        public static bool loadCustomer(string path)
        {
            if (File.Exists(path))
            {

                StreamReader sr = new StreamReader(path);
                while (!sr.EndOfStream)
                {
                    List<purchasedProducts> products = new List<purchasedProducts>();
                    string line = sr.ReadLine();
                    string[] cust = line.Split(',');
                    string name = cust[0];
                    string pass = cust[1];
                    string role = cust[2];
                    string prod = cust[3];
                    MUser id = new MUser(name, pass, role);
                    string[] p = prod.Split(';');
                    for (int i = 0; i < p.Length - 1; i++)
                    {
                        string[] pDetail = p[i].Split('-');
                        string pName = pDetail[0];
                        int pQuantity = int.Parse(pDetail[1]);
                        purchasedProducts purchasedProducts = new purchasedProducts(pName, pQuantity);
                        Product p1 = ProductDL.isValidProduct(pName);
                        if (p1 != null)
                        {
                            products.Add(purchasedProducts);
                        }
                    }

                    Customer customer = new Customer(id, products);
                    addToList(customer);
                }
                sr.Close();
                return true;
            }
            return false;

        }
        public static void storeCustomer()
        {
            string path = "Customer.txt";
            StreamWriter sw = new StreamWriter(path, false);
            foreach (Customer c in customers)
            {
                sw.Write(c.id.getUserName() + "," + c.id.getPassword() + "," + c.id.getRole() + ",");
                foreach (purchasedProducts p in c.products)
                {
                    sw.Write(p.Name + "-" + p.Quantity + ";");
                }
                sw.WriteLine();
            }
            sw.Flush();
            sw.Close();
        }
    }
}

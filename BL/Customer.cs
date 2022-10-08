using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DL;
namespace BL
{
    internal class Customer
    {
        public MUser id;
        public List<purchasedProducts> products = new List<purchasedProducts>();
        public Customer() { }
        public Customer(MUser id, List<purchasedProducts> p)
        {
            this.id = id;
            this.products = p;
        }
        public float price()
        {
            float price = 0;
            foreach (purchasedProducts p in products)
            {
                Product product = ProductDL.isValidProduct(p.Name);
                if (product != null)
                {

                    price = price + Product.calculateTax(product)*p.Quantity;

                }
            }
            return price;

        }
        public void addToList(purchasedProducts p)
        {
            if (p != null)
                products.Add(p);
        }
    }
   
}

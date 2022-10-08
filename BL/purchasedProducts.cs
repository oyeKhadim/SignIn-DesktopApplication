using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class purchasedProducts
    {
        private string name;
        private int quantity;
        public purchasedProducts(string name, int quantity)
        {
            this.Quantity = quantity;
            this.Name = name;
        }

        public string Name { get => name; set => name = value; }
        public int Quantity { get => quantity; set => quantity = value; }

      
    }
}

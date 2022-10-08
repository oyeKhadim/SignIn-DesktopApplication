using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    internal class Product
    {
        private string name;
        private string catagory;
        private int price;
        private int availableQuantity;
        private int minimumQuantity;

        public string Name { get => name; set => name = value; }
        public string Catagory { get => catagory; set => catagory = value; }
        public int Price { get => price; set => price = value; }
        public int AvailableQuantity { get => availableQuantity; set => availableQuantity = value; }
        public int MinimumQuantity { get => minimumQuantity; set => minimumQuantity = value; }

        public string getName() { return Name; }
        public string getCatagory() { return Catagory; }
        public int getPrice() { return Price; }
        public int getAvailableQuantity() { return AvailableQuantity; }
        public int getMinimumQuantity() { return MinimumQuantity; }
        public void setName(string name) { this.Name = name; }
        public void seCatagory(string catagory) { this.Catagory = catagory; }
        public void setPrice(int price) { this.Price = price; }
        public void setAvailableQuantity(int availableQuantity) { this.AvailableQuantity = availableQuantity; }
        public void setMinimumQuantity(int minimumQuantity) { this.MinimumQuantity = minimumQuantity; }
        public Product(string name, string catagory, int price, int availableQuantity, int minimumQuantity)
        {
            this.Name = name;
            this.Catagory = catagory;
            this.Price = price;
            this.AvailableQuantity = availableQuantity;
            this.MinimumQuantity = minimumQuantity;
        }
        public static float calculateTax(Product p)
        {
            float tax , Tax=0;
            if (p == null) { }
            else
            {
                if (p.Catagory == "Grocery")
                {
                    tax = 10;
                }
                else if (p.Catagory == "Fruit")
                {
                    tax = 5;
                }
                else
                {
                    tax = 15;
                }
                Tax = p.Price + p.Price * tax / 100;
            }
            return Tax;
        }
    }
}

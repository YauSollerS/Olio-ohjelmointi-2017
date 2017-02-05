using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2
{
    class Product
    {
        public string Nimi { get; set; }
        public decimal Hinta { get; set; }

        public Product (string name, decimal price)
        {
            Nimi = name;
            Hinta = price;

        }

        public override string ToString()
        {
            return Nimi + " " + Hinta +" e";
        }
    }

    class Cart
    {
        private List<Product> products;

        public List<Product> Productlist
        {
            get { return products; }
        }
        public Cart()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product hlo)
        {
            products.Add(hlo);
        }
    }
}

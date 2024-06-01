using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    internal class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public Type Type { get; set; }

        public Product(string name, int price, Type type)
        {
            Name = name;
            Price = price;
            Type = type;
        }

        internal void GetDetails(Product product)
        {
            Console.WriteLine($"{product.Name}, {product.Price}, {product.Type}");
        }
    }
}

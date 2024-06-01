using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task12
{
    internal class Catalog
    {
        public Product[] products = new Product[0];
        public void AddProduct(Product product)
        {
            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
        }

        public void GetAll()
        {
            foreach (Product product in products)
            {
                product.GetDetails(product);
            }
        }

        public void GetAllProductsByType(Type type)
        {
            foreach (Product product in products)
            {
                if (type == product.Type)
                {
                    product.GetDetails(product);
                }
            }
        }
    }
}

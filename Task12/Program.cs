using System.Threading.Tasks;
using Task12;

internal class Program
{
    private static void Main(string[] args)
    {
        Product product1 = new Product("harry potter", 10, product.Type.Books);
        Product product2 = new Product("Samsung", 3000, product.Type.Electronics);
        Catalog catalog = new Catalog();
        catalog.AddProduct(product1);
        catalog.AddProduct(product2);
        catalog.GetAll();
        catalog.GetAllProductsByType(product.Type.Books);

    }
}
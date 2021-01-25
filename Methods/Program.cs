using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "elma";
            product1.Price = 15;
            product1.description = "amasya elması";

            Product product2 = new Product();
            product2.Name = "karpuz";
            product2.Price = 10;
            product2.description = "karpuz";


            Product[] products = new Product[] { product1, product2 };
            foreach (var product in products)
            {
                Console.WriteLine(product.Name + "" +" : " +  product.Price);

            }
            ProductManager productManager = new ProductManager();
            productManager.Add();
        }
    }
}

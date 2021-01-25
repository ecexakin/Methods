using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 3;
            product1.ProductName = "masa";
            product1.UnıtPrice = 200;
            product1.UnitsInStock = 10;

            // or 
            Product product2 = new Product {Id = 2 , ProductName = "kamera" , CategoryId = 5  , UnitsInStock = 52 , UnıtPrice = 1500};

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);
                            
        }
    }
}

using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product
            {
                Id = 1,
                CategoryId = 2,
                ProductName = "Masa",
                UnitPrice = 500,
                UnitsInStock = 3
            };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);


            
            // int, double, bool, ... => Değer Tip
            // diziler, class, abstract class, interface, ... => Referans Tip

            Console.ReadLine();
        }
    }
}

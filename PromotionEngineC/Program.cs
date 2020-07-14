using System;
using System.Collections.Generic;

namespace PromotionEngineC
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductService ps = new ProductService();
            List<Product> products = new List<Product>();

            Console.WriteLine("Please enter total number of order");
            int x = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Enter the type of SKU product:A,B,C or D");
                string type = Console.ReadLine();
                               
                Product p = new Product();
                p.Id = type;
                ps.GetPriceByType(p);
                products.Add(p);
            }

            int totalPrice = ps.GetTotalPrice(products);

            Console.WriteLine("Total Order Value =" + totalPrice);
            Console.ReadLine();
        }
    }
}

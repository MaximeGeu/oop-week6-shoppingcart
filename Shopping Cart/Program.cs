using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping_Cart
{
    class Program
    {
        static void Main(string[] args)
        {
            Product apple = new Product { Name = "Apple", Price = 0.6 };
            Product orange = new Product { Name = "Orange", Price = 0.25 };

            List<Product> list = new List<Product>();
            list.Add(apple);
            list.Add(apple);
            list.Add(orange);
            list.Add(apple);
            list.Add(orange);

            Till till = new Till();
            till.Sum(list);

            Console.WriteLine($"Total price is {till.Total}");

            Console.ReadKey();

        }
    }
}

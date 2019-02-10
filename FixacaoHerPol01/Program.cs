using System;
using FixacaoHerPol01.Entities;
using System.Globalization;
using System.Collections.Generic;

namespace FixacaoHerPol01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>(); 

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write("Common, Used or Imported? (c/u/i)");
                char prodType = char.Parse(Console.ReadLine());
                Console.WriteLine("Product #" + i + " Data");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (prodType == 'c' || prodType == 'C')
                {

                  list.Add(new Product(name, price));

                } else if (prodType == 'u' || prodType == 'U')
                {
                  
                    Console.Write("Manufacture Date: (DD/MM/YYYY) ");
                    DateTime manufDate = DateTime.Parse(Console.ReadLine());

                    list.Add(new UsedProduct(name, price, manufDate));
                }
                else if (prodType == 'i' || prodType == 'I')
                {
                     
                    Console.Write("Customs fee: ");
                    double custFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new ImportedProduct(name, price, custFee));
                }

            }
            Console.WriteLine("PRICE TAGS");
            foreach(Product prod in list)
            {
                Console.WriteLine(prod.PriceTag());
            }
 
        }
    }
}

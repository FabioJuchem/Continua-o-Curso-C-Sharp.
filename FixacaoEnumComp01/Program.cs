using System;
using System.Globalization;
using System.Collections.Generic;
using FixacaoEnumComp01.Entities.Enums;
using FixacaoEnumComp01.Entities;

namespace FixacaoEnumComp01
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter cliente Data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (DD/MM/YYYY): ");
            DateTime date = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Enter Order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How Many items to this order? ");
            
            Client client = new Client(name, email, date);
            Order order = new Order(DateTime.Now, status, client);

            int n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter #"+i+" item data: ");
                Console.Write("Product name: ");
                string prodName = Console.ReadLine();
                Console.Write("Product price: ");
                double prodPrice = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity :");
                int prodQuantity = int.Parse(Console.ReadLine());

                Product product = new Product(prodName, prodPrice);
                OrderItem orderItem = new OrderItem(prodQuantity, prodPrice, product);

                order.AddItem(orderItem);

            }

            Console.WriteLine(order);

        }
    }
}

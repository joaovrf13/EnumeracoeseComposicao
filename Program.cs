using Exercicio03.Entities;
using Exercicio03.Entities.Enums;
using System;
using System.Globalization;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {




            {

                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Birth date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter order data: ");
                Console.Write("Status: ");
                string status = Console.ReadLine();

                Console.Write("How many items to this order? ");
                int n = int.Parse(Console.ReadLine());


                Client client = new Client(name, email, date);
                Order order = new Order();
                order.Moment = DateTime.Now;
                order.Products = new List<OrderItem>();



                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine($"Enter #{i + 1} item data: ");
                    Console.Write("Product name: ");
                    string productName = Console.ReadLine();
                    Console.Write("Product price: ");
                    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Quantity: ");
                    int quantity = int.Parse(Console.ReadLine());
                    OrderItem item = new OrderItem(productName, quantity, price);
                    order.Products.Add(item);

                }

                Console.WriteLine("ORDER SUMMARY: ");
                Console.WriteLine($"Order moment: {order.Moment.ToString("dd/MM/yyyy HH:mm:ss")}");
                Console.WriteLine(client);
                Console.WriteLine("Order items:");
                foreach (var item in order.Products)
                {
                    Console.WriteLine(item);
                }
                Console.WriteLine($"Total price: ${order.GetTotal().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
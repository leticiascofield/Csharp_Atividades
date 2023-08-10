using POOExercicio14.Entities;
using POOExercicio14.Entities.Enums;
using System;
using System.Globalization;

namespace Course {
    internal class Program {
        static void Main(string[] args) {

            Order order = new Order();
            order.Client = new Client();

            Console.WriteLine("Enter client data:");
            Console.Write("Name: ");
            order.Client.Name = Console.ReadLine();
            Console.Write("Email: ");
            order.Client.Email = Console.ReadLine();
            Console.Write("Birth data (DD/MM/YYYYY): ");
            order.Client.BirthDate = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter order data:");
            order.Moment = DateTime.Now;
            Console.Write("Status: ");
            order.Status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int n = int.Parse(Console.ReadLine());
            OrderItem[] orderItem = new OrderItem[n];

            for(int i = 0; i < n; i++) {
                orderItem[i] = new OrderItem();
                orderItem[i].Product  = new Product();
                Console.WriteLine("Enter #" + (i + 1) + " item data:");
                Console.Write("Product name: ");
                orderItem[i].Product.Name = Console.ReadLine();
                Console.Write("Product price: ");
                orderItem[i].Product.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantity: ");
                orderItem[i].Quantity = int.Parse(Console.ReadLine());
                order.AddItem(orderItem[i]);
            }

            Console.WriteLine();
            Console.WriteLine("ORDER SUMMARY");
            Console.WriteLine("Order moment: " + order.Moment);
            Console.WriteLine("Order status: " + order.Status);
            Console.WriteLine("Client: " + order.Client);
            Console.WriteLine("Order items:");

            foreach(OrderItem item in order.Items) {
                Console.WriteLine(item);
            }

            Console.WriteLine("Total price: $" + order.Total().ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
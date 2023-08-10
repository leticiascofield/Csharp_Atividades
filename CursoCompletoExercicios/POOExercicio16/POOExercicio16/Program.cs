using POOExercicio16.Entities;
using System;
using System.Globalization;


namespace Course {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Enter the number of products: ");
            int N = int.Parse(Console.ReadLine());

            Product[] product = new Product[N];
            char[] answer = new char[N];

            for(int i = 0; i < N; i++) {
                Console.WriteLine($"Product #{i + 1} data:");
                Console.Write("Commom, used or imported (c/u/i)? ");
                answer[i] = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (answer[i] == 'c') {
                    product[i] = new Product(name, price);
                } else if (answer[i] == 'u') {
                    Console.Write("Manufacture data (DD/MM/YYYY): ");
                    DateTime date = DateTime.Parse(Console.ReadLine());
                    product[i] = new UsedProduct(name, price, date);
                } else if (answer[i] == 'i') {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    product[i] = new ImportedProduct(name, price, customsFee);
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            for(int i = 0; i < N; i++) {
                Console.WriteLine(product[i].PriceTag());
            }
            

        }
    }
}
using POOExercicio15.Entities;
using System;
using System.Globalization;
using System.Xml.Linq;

namespace Course {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Enter the number of employess: ");
            int N = int.Parse(Console.ReadLine());

            Employee[] employee = new Employee[N];
            char[] answer = new char[N];

            for (int i = 0; i < N; i++) {
                Console.WriteLine($"Employee #{i+1} data:");
                Console.Write("Outsourced (y/n)? ");
                answer[i] = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (answer[i] == 'y') {
                    Console.Write("Additional charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    employee[i] = new OutsourceEmployee(name, hours, valuePerHour, additionalCharge);
                } else {
                    employee[i] = new Employee(name, hours, valuePerHour);
                }
            }

            Console.WriteLine();
            Console.WriteLine("PAYMENTS:");
            for (int i = 0;i < N;i++) {
                Console.WriteLine(employee[i].Name + " - $ " + employee[i].Payment().ToString("F2", CultureInfo.InvariantCulture));
            }

            

        }
    }
}
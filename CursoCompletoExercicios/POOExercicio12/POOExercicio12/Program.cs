using POOExercicio12.Entities;
using POOExercicio12.Entities.Enums;
using System;
using System.Diagnostics.Contracts;
using System.Globalization;

namespace Course {
    internal class Program {
        static void Main(string[] args) {

            Worker worker = new Worker();
            Console.Write("Enter departmet's name: ");
            worker.Department = new Department(Console.ReadLine());
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            worker.Name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            worker.Level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base salary: ");
            worker.BaseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("How many contracts to this worker? ");
            int n =  int.Parse(Console.ReadLine());
            HourContract[] contract = new HourContract[n];

            for(int i = 0; i < n; i++) {
                contract[i] = new HourContract();
                Console.WriteLine("Enter #" + (i+1) + " contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                contract[i].Date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                contract[i].ValuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                contract[i].Hours = int.Parse(Console.ReadLine());
                worker.AddContract(contract[i]);
            }

            Console.Write("Enter month and year to calculate income (MM/YYYY): ");
            string[] s = Console.ReadLine().Split('/');
            int month = int.Parse(s[0]);
            int year = int.Parse(s[1]);

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + s[0] + "/" + s[1] + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
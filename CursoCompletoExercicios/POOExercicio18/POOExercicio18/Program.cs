using System;
using System.Globalization;
using POOExercicio18.Entities;


namespace Course {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Enter the number of tax payers: ");
            int N = int.Parse(Console.ReadLine());

            TaxPayer[] taxPayer = new TaxPayer[N];
            char[] answer = new char[N];

            for(int i = 0; i < N; i++) {
                Console.WriteLine($"Tax payer #{i + 1} data:");
                Console.Write("Individual or company (i/c)? ");
                answer[i] = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (answer[i] == 'i') {
                    Console.Write("Healthcare expenses: ");
                    double healthcareExpenses = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    taxPayer[i] = new Individual(name, annualIncome, healthcareExpenses);
                } else {
                    Console.Write("Number of employees: ");
                    int employeeCount = int.Parse(Console.ReadLine());
                    taxPayer[i] = new Company(name, annualIncome, employeeCount);
                }
            }

            double totalTaxes = 0;
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            for(int i = 0; i < N; i++) {
                Console.WriteLine(taxPayer[i].Name + ": $ " + 
                    taxPayer[i].Tax().ToString("F2", CultureInfo.InvariantCulture));
                totalTaxes += taxPayer[i].Tax();
            }

            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
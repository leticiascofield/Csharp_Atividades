using System;
using System.Globalization;

namespace curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dinheiro = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int cedulas100 = (int)dinheiro / 100;
            double resto1 = dinheiro % 100;
            int cedulas50 = (int)resto1 / 50;
            double resto2 = resto1 % 50;
            int cedulas20 = (int)resto2 / 20;
            double resto3 = resto2 % 20;
            int cedulas10 = (int)resto3 / 10;
            double resto4 = resto3 % 10;
            int cedulas5 = (int)resto4 / 5;
            double resto5 = resto4 % 5;
            int cedulas2 = (int)resto5 / 2;
            double resto6 = resto5 % 2;
            int moeda1 = (int)resto6 / 1;
            double resto7 = (resto6 % 1) * 100;
            int moeda50 = (int)resto7 / 50;
            int resto8 = (int)resto7 % 50;
            int moeda25 = resto8 / 25;
            int resto9 = resto8 % 25;
            int moeda10 = resto9 / 10;
            int resto10 = resto9 % 10;
            int moeda05 = resto10 / 5;
            int moeda01 = resto10 % 5;

            Console.WriteLine(resto10);
            Console.WriteLine("NOTAS:");
            Console.WriteLine(cedulas100 + " nota(s) de R$ 100.00");
            Console.WriteLine(cedulas50 + " nota(s) de R$ 50.00");
            Console.WriteLine(cedulas20 + " nota(s) de R$ 20.00");
            Console.WriteLine(cedulas10 + " nota(s) de R$ 10.00");
            Console.WriteLine(cedulas5 + " nota(s) de R$ 5.00");
            Console.WriteLine(cedulas2 + " nota(s) de R$ 2.00");
            Console.WriteLine("MOEDAS:");
            Console.WriteLine(moeda1 + " moeda(s) de R$ 1.00");
            Console.WriteLine(moeda50 + " moeda(s) de R$ 0.50");
            Console.WriteLine(moeda25 + " moeda(s) de R$ 0.25");
            Console.WriteLine(moeda10 + " moeda(s) de R$ 0.10");
            Console.WriteLine(moeda05 + " moeda(s) de R$ 0.05");
            Console.WriteLine(moeda01 + " moeda(s) de R$ 0.01");

        }
    }
}

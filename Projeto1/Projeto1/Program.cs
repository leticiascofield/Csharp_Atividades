using System;
using System.Globalization;

namespace curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;

            string[] vet = Console.ReadLine().Split(' ');
            double A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            double B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            double C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            double triangulo = (A * C) / 2.0;
            double circulo = pi * Math.Pow(C, 2.0);
            double trapezio = ((A + B) / 2.0) * C;
            double quadrado = B * B;
            double retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + A.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRIANGULO: " + B.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRIANGULO: " +C.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
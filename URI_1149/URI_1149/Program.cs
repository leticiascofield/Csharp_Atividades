using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            for (int k = 2; int.Parse(vet[1]) <= 0; k++)
            {
                vet[1] = vet[k];
            }

            int A = int.Parse(vet[0]);
            int N = int.Parse(vet[1]);
            int soma = 0;

            for (int i = 0; i < N; i++)
            {
                soma += A + i;
            }

            Console.WriteLine(soma);
        }
    }
}
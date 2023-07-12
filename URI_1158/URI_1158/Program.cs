using System;
using System.Globalization;

namespace curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int X = int.Parse(vet[0]);
                int Y = int.Parse(vet[1]);
                int count = 0, soma = 0;

                for (int j = 0; count < Y; j++)
                {
                    if ((X + j) % 2 != 0)
                    {
                        soma += X + j;
                        count++;
                    }
                }

                Console.WriteLine(soma);
            }
        }
    }
}
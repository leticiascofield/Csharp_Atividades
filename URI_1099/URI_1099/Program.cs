using System;
using System.Globalization;

namespace curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for(int i = 0; i < N; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int X = int.Parse(vet[0]);
                int Y = int.Parse(vet[1]);
                int min;
                int max;
                int soma;
                soma = 0;

                if (X < Y)
                {
                    max = Y;
                    min = X;
                } else
                {
                    max = X;
                    min = Y;
                }

                for(int j = min+1; j < max; j++)
                {
                    if(j % 2 != 0)
                    {
                        soma += j;
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}
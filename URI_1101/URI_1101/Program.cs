using System;
using System.Globalization;

namespace curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int M = 1;
            int N = 1;
            

            while(M > 0 && N > 0)
            {
                string[] vet = Console.ReadLine().Split(' ');
                M = int.Parse(vet[0]);
                N = int.Parse(vet[1]);
                int min;
                int max;
                int soma;
                soma = 0;

                if (M > 0 && N > 0)
                {
                    if (M < N)
                    {
                        min = M;
                        max = N;
                    }
                    else
                    {
                        min = N;
                        max = M;
                    }

                    for (int i = min; i <= max; i++)
                    {
                        Console.Write(i + " ");
                        soma += i;
                    }
                    Console.WriteLine("Sum=" + soma);
                }

            }
            





        }
    }
}
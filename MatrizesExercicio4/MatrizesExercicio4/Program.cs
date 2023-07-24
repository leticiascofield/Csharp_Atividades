using System;
using System.Globalization;

namespace curso
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int[,] mat = new int[N, N];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < N; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int soma = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i < j)
                    {
                        soma += mat[i, j];
                    }
                }
            }
            Console.WriteLine(soma);
        }
    }

}



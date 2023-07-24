using System;
using System.Globalization;

namespace curso
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int M = int.Parse(Console.ReadLine());
            int[,] mat = new int[N, M];

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < M; j++)
                {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            int F = int.Parse(Console.ReadLine())-1;
            int aux = mat[F,M-1];

            for (int j = M-1; j >= 0; j--)
            {
                if (j > 0)
                {
                    mat[F, j] = mat[F, j - 1];
                }
                else
                {
                    mat[F, j] = aux;
                }
            }

            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}



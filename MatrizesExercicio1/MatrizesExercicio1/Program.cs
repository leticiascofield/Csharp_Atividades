using System;
using System.Globalization;

namespace curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int N = int.Parse(s[0]);
            int M = int.Parse(s[1]);
            int[,] mat = new int[N, M];

            for(int i = 0; i < N; i++)
            {
                string[] s2 = Console.ReadLine().Split(' ');
                for(int j = 0; j < M; j++)
                {
                    mat[i,j] = int.Parse(s2[j]);
                }
            }

            Console.WriteLine("VALORES NEGATIVOS:");

            for(int i = 0; i < N;i++)
            {
                for(int j = 0; j < M;j++)
                {
                    if (mat[i,j] < 0)
                    {
                        Console.WriteLine(mat[i,j]);
                    }
                }
            }
        }
    }

}



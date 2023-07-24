using System;
using System.Globalization;

namespace curso
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            string[] sA = Console.ReadLine().Split(' ');
            string[] sB = Console.ReadLine().Split(' ');
            int[] C = new int[N];

            for(int i = 0; i < N; i++)
            {
                C[i] = int.Parse(sA[i]) + int.Parse(sB[i]);
            }

            for (int i = 0; i < N; i++)
            {
                Console.Write(C[i] + " ");
            }

        }
    }

}



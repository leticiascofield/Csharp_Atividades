using System;
using System.Globalization;

namespace curso
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            int[] vet = new int[N];

            string[] s = Console.ReadLine().Split(' ');
            int count = 0;

            for (int i = 0; i < N; i++)
            {
                vet[i] = int.Parse(s[i]);
            }

                for (int i = 0; i < N; i++)
            {
                if (vet[i] % 2 == 0)
                {
                    Console.Write(vet[i] + " ");
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(count);
       
        }
    }

}



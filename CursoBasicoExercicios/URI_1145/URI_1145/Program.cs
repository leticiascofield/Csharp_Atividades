using System;
using System.Globalization;

namespace curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int X = int.Parse(vet[0]);
            int Y = int.Parse(vet[1]);

          
            for(int j = 1; j <= Y; j++)
            {
                if (j % X != 0)
                {
                    Console.Write(j + " ");
                } else{
                    Console.WriteLine(j);
                }
            }
        }
    }
}
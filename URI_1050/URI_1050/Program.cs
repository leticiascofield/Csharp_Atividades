using System;
using System.Globalization;

namespace curso
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int X = 0, Y = 0, soma = 0, count = 0;
            X = int.Parse(Console.ReadLine());

            while(X >= Y)
            {
                Y = int.Parse(Console.ReadLine());
            }

            for(int i = 0; soma < Y; i++)
            {
                soma += X + i;
                count++;
            }

            Console.WriteLine(count);
        }
    }
}
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
                int X = int.Parse(Console.ReadLine());
                bool b = false;

                for (int j = X - 1; j > 1; j--)
                {
                    if (X % j == 0)
                    {
                        b = true;
                    }
                }

                if (b)
                {
                    Console.WriteLine(X + " nao eh primo");
                } else
                {
                    Console.WriteLine(X + " eh primo");
                }
            }
            
        }
    }
}
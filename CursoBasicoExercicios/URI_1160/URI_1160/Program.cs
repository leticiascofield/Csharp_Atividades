using System;
using System.Globalization;

namespace curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int T = int.Parse(Console.ReadLine());
            
            for(int i = 0; i < T; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int PA = int.Parse(vet[0]);
                int PB = int.Parse(vet[1]);
                double G1 = double.Parse(vet[2], CultureInfo.InvariantCulture)/100.0;
                double G2 = double.Parse(vet[3], CultureInfo.InvariantCulture) /100.0;
                int ano;
                bool b = false;

                for(ano = 1; (ano <= 100); ano++)
                {
                    PA += (int)(PA * (G1));
                    PB += (int)(PB * (G2));
          
                    if (PA > PB && b == false)
                    {
                        Console.WriteLine(ano + " anos.");
                        b = true;
                    }

                }
                if(!b)
                {
                    Console.WriteLine("Mais de 1 seculo.");
                }
            }
        }
    }
}
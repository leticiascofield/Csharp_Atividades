using System;
using System.Globalization;

namespace curso
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int N = int.Parse(Console.ReadLine());
            double[] vet = new double[N];

            string[] s = Console.ReadLine().Split(' ');

            for(int i = 0; i < N; i++)
            {
                vet[i] = double.Parse(s[i], CultureInfo.InvariantCulture);
            }

            double maior = vet[0];
            int posicaoMaior = 0;

            for(int i = 0; i < N; i++)
            {
                if(maior < vet[i])
                {
                    maior = vet[i];
                    posicaoMaior = i;
                }
            }
            Console.WriteLine(maior.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine(posicaoMaior);
        }
    }

}



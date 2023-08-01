using System;
using System.Globalization;
using System.Collections.Generic;

namespace curso {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Digite a ordem da matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] mat = new int[n,n];
            Console.WriteLine("Digite os elementos da matriz:");

            for (int i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++) {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("Diagonal principal:");
            for (int i = 0; i < n; i++) {
                Console.Write(mat[i, i] + " ");
            }
            Console.WriteLine();

            int count = 0;
            for(int i = 0; i < n; i++) {       
                for (int j = 0; j < n; j++) {
                    if (mat[i, j] < 0) {
                        count++;
                    }
                }
            }
            Console.WriteLine("Quantidade de números negativos: " + count);

        }     
    }
}
using System;
using System.Globalization;
using System.Collections.Generic;

namespace curso {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite quantas linhas e colunas: ");
            string[] aux = Console.ReadLine().Split(' ');
            int n = int.Parse(aux[0]);
            int m = int.Parse(aux[1]);

            int[,] mat = new int[n, m];
            Console.WriteLine("Digite os elementos da matriz:");

            for (int i = 0; i < n; i++) {
                string[] s = Console.ReadLine().Split(' ');
                for (int j = 0; j < m; j++) {
                    mat[i, j] = int.Parse(s[j]);
                }
            }

            Console.WriteLine("Digite um número pertencente à matriz: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    if (mat[i, j] == num) {
                        Console.WriteLine("Posição [" + i + "," + j + "]:");
                        if (j - 1 >= 0) {
                            Console.WriteLine("Númera à esquerda: " + mat[i, j - 1]);
                        }
                        if (j + 1 <= n) {
                            Console.WriteLine("Númera à direita: " + mat[i, j + 1]);
                        }
                        if (i - 1 >= 0) {
                            Console.WriteLine("Númera acima: " + mat[i - 1, j]);
                        }
                        if (i + 1 <= m) {
                            Console.WriteLine("Númera abaixo: " + mat[i + 1, j]);
                        }
                        Console.WriteLine();
                    }
                }
            }
            

        }
    }
}
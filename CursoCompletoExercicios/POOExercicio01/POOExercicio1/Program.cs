using POOExercicio1;
using System;
using System.Globalization;

namespace curso {
    internal class Program {
        static void Main(string[] args) {

            Pessoa p1, p2;
            p1 = new Pessoa();
            p2 = new Pessoa();
            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());


            Console.WriteLine("Dados da segunda pessoa: ");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            string maisVelho;
            if (p1.Idade > p2.Idade) {
                maisVelho = p1.Nome;
            } else {
                maisVelho = p2.Nome;
            }

            Console.WriteLine("Pessoa mais velha: " + maisVelho);

        }
    }

}
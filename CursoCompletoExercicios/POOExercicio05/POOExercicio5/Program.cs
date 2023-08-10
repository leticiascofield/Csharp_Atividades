using POOExercicio5;
using System;
using System.Globalization;

namespace curso {
    internal class Program {
        static void Main(string[] args) {

            Aluno a = new Aluno();

            Console.Write("Nome do Aluno: ");
            a.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            a.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Nota final = " + a.NotaFinal().ToString("F2", CultureInfo.InvariantCulture));
            a.Aprovacao();

        }
    }

}
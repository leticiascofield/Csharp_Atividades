using POOExercicio9;
using System;
using System.Globalization;
using System.Collections.Generic;

namespace curso {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Quantos funcionarios serão registrados? ");
            int n = int.Parse(Console.ReadLine());

            List<Funcionario> lista = new List<Funcionario>();

            for (int i = 0; i < n; i++) {
                Console.WriteLine();
                Console.WriteLine("Funcionario #" + (i + 1) + ":");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Salário: ");
                double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Funcionario funcionario = new Funcionario() { 
                    Id = id, 
                    Nome = nome, 
                    Salario = salario 
                };

                lista.Add(funcionario);
            }

            Console.WriteLine();
            Console.Write("Insira o Id do funcionário que terá aumento de salário: ");
            int idInserido = int.Parse(Console.ReadLine());
            bool teste = false;

            foreach (Funcionario funcionario in lista) {
                if (funcionario.Id == idInserido) {
                    Console.Write("Insira a porcentagem de aumento: ");
                    double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    teste = true;
                    funcionario.AumentarSalario(porcentagem);
                } 
            }

            if (teste == false) {
                Console.WriteLine("Esse Id não existe");
            }

            Console.WriteLine();
            Console.WriteLine("Lista dos funcionários atualizada:");
            foreach (Funcionario funcionario in lista) {
                Console.WriteLine(funcionario);
            }


        }

        static bool Teste(Funcionario f, int idTeste) {
            if (f.Id == idTeste) {
                return true;
            } else { 
                return false;
            }
        }
    }

}
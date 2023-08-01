using POOExercicio7;
using System;
using System.Globalization;

namespace curso {
    internal class Program {
        static void Main(string[] args) {

            ContaBancaria contaBancaria;

            Console.Write("Entre o número da conta: ");
            int numeroConta = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string nomeTitular = Console.ReadLine();
            Console.Write("Haverá depósito inicial (s/n)? ");
            char resposta = char.Parse(Console.ReadLine());

            if (resposta == 's') {
                Console.Write("Entre o valor de depósito inicial: ");
                double saldo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                contaBancaria = new ContaBancaria(numeroConta, nomeTitular, saldo);
            } else {
                contaBancaria = new ContaBancaria(numeroConta, nomeTitular);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre com um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Depositar(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaBancaria);

            Console.WriteLine();
            Console.Write("Entre com um valor para saque: ");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            contaBancaria.Sacar(valor);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(contaBancaria);

        }
    }

}
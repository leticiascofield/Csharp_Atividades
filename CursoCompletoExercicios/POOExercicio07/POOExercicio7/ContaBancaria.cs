using System;
using System.Globalization;


namespace POOExercicio7 {
    internal class ContaBancaria {

        private int _numeroConta;
        private string _nomeTitular;
        public double Saldo { get; private set; }

        public ContaBancaria(int numeroConta, string nomeTitular) {
            _numeroConta = numeroConta;
            _nomeTitular = nomeTitular;
        }

        public ContaBancaria(int numeroConta, string nomeTitular, double saldo) :
            this(numeroConta, nomeTitular) {
            Saldo = saldo;
        }

        public void Depositar(double deposito) {
            Saldo += deposito;
        }

        public void Sacar(double saque) {
            Saldo -= saque + 5.0;
        }

        public override string ToString() {
            return "Conta " + _numeroConta + ", Titular: " +
                _nomeTitular + ", Saldo: $ " +
                Saldo.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

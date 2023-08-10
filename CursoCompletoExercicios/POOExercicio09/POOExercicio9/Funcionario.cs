using System;
using System.Globalization;

namespace POOExercicio9 {
    internal class Funcionario {

        public int Id;
        public string Nome;
        public double Salario;

        public void AumentarSalario(double porcentagem) {
            Salario *= 1 + (porcentagem/100);
        }

        public override string ToString() {
            return Id + ", " + Nome + ", " + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}

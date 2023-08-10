using System;
using System.Globalization;

namespace POOExercicio5 {
    internal class Aluno {

        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal() {
            return Nota1 + Nota2 + Nota3;
        }

        public void Aprovacao() {
            if (NotaFinal() < 60) {
                double falta = 60 - NotaFinal();
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " +
                    falta.ToString("F2", CultureInfo.InvariantCulture) +
                    " PONTOS");
            } else {
                Console.WriteLine("APROVADO");
            }
        }

    }
}

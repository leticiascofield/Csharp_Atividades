using System;

namespace POOExercicio6 {
    internal class ConversorDeMoeda {

        static public double Cotacao;
        static public double Quantidade;
        static double IOF = 1.06;

        static public double RealEquivalente() {
            return Cotacao * Quantidade * IOF;
        }
    }
}

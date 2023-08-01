using System;
using System.Globalization;

namespace POOExercicio8 {
    internal class Estudante {

        public string Nome;
        public string Email;

        public Estudante(string nome, string email) {
            Nome = nome;
            Email = email;
        }

        public override string ToString() {
            return Nome + ", " + Email;
        }
    }
}

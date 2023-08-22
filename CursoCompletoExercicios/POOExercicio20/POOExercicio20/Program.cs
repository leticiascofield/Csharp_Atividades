using System;
using System.Globalization;
using System.IO;

namespace curso {
    internal class Program {
        static void Main(string[] args) {

            string sourcePath = @"C:\Users\letic\OneDrive\Documentos\GitHub\Csharp_Atividades\CursoCompletoExercicios\POOExercicio20\TV LED,1290.99,1.txt";

            string targetPath = @"C:\Users\letic\OneDrive\Documentos\GitHub\Csharp_Atividades\CursoCompletoExercicios\POOExercicio20\out";

            try {

                Directory.CreateDirectory(targetPath);
                File.Create(targetPath + @"\saida.txt").Close();

                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath + @"\saida.txt")) {
                    foreach (string line in lines) {
                        string[] s = line.Split(',');
                        double preco = double.Parse(s[1], CultureInfo.InvariantCulture);  
                        double total = preco * int.Parse(s[2]);
                        sw.WriteLine(s[0] + "," + total.ToString("F2", CultureInfo.InvariantCulture));
                        
                    }
                }
               
            } catch (IOException ex) {
                Console.WriteLine("ERRO: " + ex.Message);
            }
        }
    }

}
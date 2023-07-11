using System;
using System.Globalization;

namespace curso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');
            int diaInicio = int.Parse(vet[1]);
            string[] vet2 = Console.ReadLine().Split(' ');
            int horaInicio = int.Parse(vet2[0]);
            int minutoInicio = int.Parse(vet2[2]);
            int segundoInicio = int.Parse(vet2[4]);

            string[] vet3 = Console.ReadLine().Split(' ');
            int diaFim = int.Parse(vet3[1]);
            string[] vet4 = Console.ReadLine().Split(' ');
            int horaFim = int.Parse(vet4[0]);
            int minutoFim = int.Parse(vet4[2]);
            int segundoFim = int.Parse(vet4[4]);

            int tempoInicio = (diaInicio * 3600 * 24) + (horaInicio * 3600) + (minutoInicio * 60) + segundoInicio;
            int tempoFim = (diaFim * 3600 * 24) + (horaFim * 3600) + (minutoFim * 60) + segundoFim;
            int duracaoTotal = tempoFim - tempoInicio;
            int duracaoDia = duracaoTotal / (3600 * 24);
            int duracaoResto = duracaoTotal % (3600 * 24);
            int duracaoHora = duracaoResto / 3600;
            int duracaoResto2 = duracaoResto % 3600;
            int duracaoMinuto = duracaoResto2 / 60;
            int duracaoSegundo = duracaoResto2 % 60;

            Console.WriteLine(duracaoDia + " dia(s)");
            Console.WriteLine(duracaoHora + " hora(s)");
            Console.WriteLine(duracaoMinuto + " minuto(s)");
            Console.WriteLine(duracaoSegundo + " segundo(s)");

        }
    }
}

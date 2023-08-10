using System;
using System.Globalization;
using POOExercicio17.Entities;
using POOExercicio17.Entities.Enums;

namespace curso {
    internal class Program {
        static void Main(string[] args) {

            Console.Write("Enter the number of shapes: ");
            int N = int.Parse(Console.ReadLine());

            Shape[] shape = new Shape[N];
            char[] answer = new char[N];

            for(int i = 0; i < N; i++) {
                Console.WriteLine($"Shape #{i + 1} data:");
                Console.Write("Rectangle or Circle (r/c)? ");
                answer[i] = char.Parse(Console.ReadLine());
                Console.Write("Color: ");
                Color color = Enum.Parse<Color>(Console.ReadLine());

                if (answer[i] == 'r') {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shape[i] = new Rectangle(color, width, height);
                } else {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    shape[i] = new Circle(color, radius);
                }
            }

            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            for(int i = 0; i < N; i++) {
                Console.WriteLine(shape[i].Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
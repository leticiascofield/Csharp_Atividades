using POOExercicio17.Entities.Enums;

namespace POOExercicio17.Entities {
    internal class Circle : Shape {

        public double Radius { get; set; }

        public Circle() { }

        public Circle(Color color, double radius) {
            Color = color;
            Radius = radius;
        }

        public override double Area() {
            return Math.Pow(Radius, 2.0) * Math.PI;
        }
    }
}

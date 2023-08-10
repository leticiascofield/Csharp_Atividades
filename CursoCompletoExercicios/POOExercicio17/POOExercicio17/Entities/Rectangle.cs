using POOExercicio17.Entities.Enums;


namespace POOExercicio17.Entities {
    internal class Rectangle : Shape {

        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle() { }

        public Rectangle(Color color, double width, double height) {
            Color = color;
            Width = width;
            Height = height;
        }

        public override double Area() {
            return Width * Height;
        }
    }
}

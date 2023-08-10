using POOExercicio17.Entities.Enums;


namespace POOExercicio17.Entities {
    internal abstract class Shape {

        public Color Color { get; set; }

        public abstract double Area();
    }
}

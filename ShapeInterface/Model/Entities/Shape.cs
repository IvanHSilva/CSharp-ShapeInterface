using ShapeInterface.Model.Enums;

namespace ShapeInterface.Model.Entities {
    public abstract class Shape {
        public Color Color { get; set; }
        public abstract double Area();
    }
}

using System.Globalization;

namespace ShapeInterface.Model.Entities {
    public class Rectangle : Shape {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height) {
            Width = width;
            Height = height;
        }

        public override double Area() {
            return Width * Height;
        }

        public override string ToString() {
            return $"Retângulo de cor {Color}, largura {Width.ToString("F2", CultureInfo.InvariantCulture)}, "
                + $"altura de {Height.ToString("F2", CultureInfo.InvariantCulture)}, "
                + $"áera de {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

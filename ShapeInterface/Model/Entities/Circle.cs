using System;
using System.Globalization;

namespace ShapeInterface.Model.Entities {
    public class Circle : Shape {
        public double Radius { get; set; }

        public Circle(double radius) {
            Radius = radius;
        }

        public override double Area() {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override string ToString() {
            return $"Círculo de cor {Color}, raio {Radius.ToString("F2", CultureInfo.InvariantCulture)}, "
                + $"áera de {Area().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}

using ShapeInterface.Model.Entities;
using ShapeInterface.Model.Enums;
using System;

namespace ShapeInterface {
    internal class Program {
        static void Main(string[] args) {
            IShape s1 = new Circle(2.0, Color.Verde);
            IShape s2 = new Rectangle(3.5, 4.5, Color.Azul);
            Console.WriteLine(s1);
            Console.WriteLine(s2);
        }
    }
}

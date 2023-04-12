using System.ComponentModel.DataAnnotations;

namespace TestTask.Shapes
{
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0) throw new ArgumentException("radius <= 0");

            Radius = radius;
        }

        public double Square() => Math.PI * Radius * Radius;
    }
}
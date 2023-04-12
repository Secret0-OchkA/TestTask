using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestTask.Shapes;

namespace TestTask
{
    public class ShapeFactory
    {
        public static IShape CreateShape(string shapeName, params double[] dimensions)
        {
            return shapeName switch
            {
                nameof(Circle) => new Circle(dimensions[0]),
                nameof(Triangle) => new Triangle(dimensions[0], dimensions[1], dimensions[2]),

                _ => throw new ArgumentException("Invalid number of dimensions for shape")
            };
        }
    }
}

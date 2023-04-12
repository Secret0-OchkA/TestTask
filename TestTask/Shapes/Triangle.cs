using System.ComponentModel.DataAnnotations;

namespace TestTask.Shapes
{
    public class Triangle : IShape
    {
        public double Side1 { get; }
        public double Side2 { get; }
        public double Side3 { get; }

        public Triangle(double side1, double side2, double side3)
        {
            if (side1 <= 0) throw new ArgumentException("Side1 <= 0");
            if (side2 <= 0) throw new ArgumentException("Side2 <= 0");
            if (side3 <= 0) throw new ArgumentException("Side3 <= 0");

            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
        }

        public double Square()
        {
            double s = (Side1 + Side2 + Side3) / 2;
            return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
        }

        public bool IsRightAngle()
        {
            var nums = new[] { Side1, Side2, Side3 }
            .Order()
            .ToList();

            return Math.Pow(nums[0], 2) + Math.Pow(nums[1], 2) == Math.Pow(nums[2], 2);
        }
    }
}
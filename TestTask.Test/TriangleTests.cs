using TestTask.Shapes;

namespace TestTask.Test
{
    public class TriangleTests
    {
        [Test]
        public void Should_CorrectSquare_When_SidsGreaterZero()
        {
            Triangle triangle = new(3, 4, 5);

            Assert.That(triangle.Square(), Is.EqualTo(6));
        }

        [TestCase(-1, 1, 1)]
        [TestCase(1, -1, 1)]
        [TestCase(1, 1, -1)]
        public void Should_ThrowExc_When_SideLessOrEqualZero(double side1, double side2, double side3)
        {
            Assert.Throws<ArgumentException>(() => new Triangle(side1, side2, side3));
        }

        [Test]
        public void Should_True_When_RightTriangle()
        {
            Triangle triangle = new(3, 4, 5);

            Assert.That(triangle.IsRightAngle(), Is.True);
        }

        [Test]
        public void Should_False_When_Not_RightTriangle()
        {
            Triangle triangle = new(1, 1, 1);

            Assert.That(triangle.IsRightAngle(), Is.False);
        }
    }
}
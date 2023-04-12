namespace TestTask.Test
{
    public class CircleTests
    {
        [Test]
        public void Should_CorrectSquare_When_RadiusGreaterZero()
        {
            Circle circle = new(10);

            Assert.That(circle.Square(), Is.EqualTo(Math.PI * 100));
        }

        [TestCase(0)]
        [TestCase(-10)]
        public void Should_ThrowExc_When_RadiusLessOrEqualZero(int radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}
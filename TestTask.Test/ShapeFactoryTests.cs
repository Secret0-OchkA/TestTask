using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTask.Test
{
    internal class ShapeFactoryTests
    {
        [TestCase(nameof(Triangle),typeof(Triangle),1,1,1)]
        [TestCase(nameof(Circle),typeof(Circle), 1)]
        public void Should_CreateByName_When_CorrectParams(string shapeName, Type shapeType, params double[] dimensions) 
        {
            IShape shape = ShapeFactory.CreateShape(shapeName, dimensions);

            Assert.That(shape, Is.TypeOf(shapeType));
        }

        [Test]
        public void Should_ThrowExc_When_UndefineShapeName()
        {
            Assert.Throws<ArgumentException>(() => ShapeFactory.CreateShape("aboba",1));
        }
    }
}

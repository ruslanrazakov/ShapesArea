using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapesAreaLib;
using System;

namespace ShapesAreaLibTests
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void EquiraterialTriangleAreaCountSuccess()
        {
            IShape triangle = new Triangle(5, 5, 5);
            Assert.IsTrue(Math.Round(triangle.GetArea(), 1) == 10.8d);
        }

        [TestMethod]
        public void CustomTriangleAreaCountSuccess()
        {
            IShape triangle = new Triangle(6, 7, 8);
            Assert.IsTrue(Math.Round(triangle.GetArea(), 1) == 20.3d);
        }

        [TestMethod]
        public void IsTriangleRight()
        {
            IShape shape = new Triangle(12, 13, 5); //Pythagorean triangle
            Triangle triangle  = (Triangle)shape;
            Assert.IsTrue(triangle.IsRight);
        }

        [TestMethod]
        [ExpectedException(typeof(ShapeZeroParameterException))]
        public void ZeroInTriangleParametersConstructor()
        {
            IShape triangle = new Triangle(0, 7, 8);
        }

        [ExpectedException(typeof(ShapeWrongParameterException))]
        public void WrongSideInTriangleParametersConstructor()
        {
            IShape triangle = new Triangle(10, 20, 30);
        }

        
        [TestMethod]
        public void CircleAreaCountSuccess()
        {
            IShape circle = new Circle(10);
            Assert.IsTrue(Math.Round(circle.GetArea(), 1) == 314.2d);
        }

        [TestMethod]
        [ExpectedException(typeof(ShapeZeroParameterException))]
        public void ZeroInCircleParametersConstructor()
        {
            IShape circle = new Circle(0);
        }
    }
}

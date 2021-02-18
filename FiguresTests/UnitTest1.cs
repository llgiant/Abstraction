using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace FiguresTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CircleAreaWIthoutValues()
        {
            //arrange
            Circle circle = new Circle();
            //act
            double area = circle.Area;
            //assert
            Assert.AreEqual(0, area);
        }

        [TestMethod]
        public void CircleAreaWIthValues()
        {
            //arrange
            Circle circle = new Circle(6);
            double expArea = Math.PI * Math.Pow(6, 2);
            //act
            double area = circle.Area;

            //assert
            Assert.AreEqual(expArea, area);
        }

        [TestMethod]
        public void TriangleAreaWIthoutValues()
        {
            //arrange
            Triangle triangle = new Triangle();

            //act
            double area = triangle.Area;

            //assert
            Assert.AreEqual(0, area);
        }

        [TestMethod]
        public void TriangleAreaWIthValues()
        {
            //arrange
            Triangle triangle = new Triangle(3, 4, 5);

            //act
            double area = triangle.Area;

            //assert
            Assert.AreEqual(6, area);
        }

        [TestMethod]
        public void TriangleIsRight()
        {
            //arrange
            Triangle triangle = new Triangle(3, 4, 5);

            //act
            bool isRight = triangle.IsRight();

            //assert
            Assert.IsTrue(isRight);
        }

        [TestMethod]
        public void AreaOfFigure()
        {
            //arrange
            Figure figure = new Figure(new Circle());

            //act
            double area = figure.Area;

            //assert
            Assert.AreEqual(0, area);
        }
    }
}

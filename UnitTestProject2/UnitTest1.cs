using Figures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject2
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
            var area = circle.Area;
            //assert
            Assert.AreEqual(0, area);
        }

        [TestMethod]
        public void CircleAreaWIthValues()
        {
            //arrange
            Circle circle = new Circle(6);
            var correctArea = Math.PI * Math.Pow(6, 2);
            //act
            var area = circle.Area;

            //assert
            Assert.AreEqual(correctArea, area);
        }

        [TestMethod]
        public void TriangleAreaWIthoutValues()
        {
            //arrange
            Triangle triangle = new Triangle();

            //act
            var area = triangle.Area;

            //assert
            Assert.AreEqual(0, area);
        }

        [TestMethod]
        public void TriangleAreaWIthValues()
        {
            //arrange
            Triangle triangle = new Triangle(3, 4, 5);

            //act
            var area = triangle.Area;

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
            var area = figure.Area;

            //assert
            Assert.AreEqual(0, area);
        }
    }
}

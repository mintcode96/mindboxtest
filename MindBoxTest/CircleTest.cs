using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBox;

namespace MindBoxTests
{
    [TestClass]
    public class CircleTest
    {
        [DataTestMethod]
        [DataRow(0)]
        [DataRow(-10)]
        public void NotCorrectRadiusTest(double radius)
        {
            Assert.ThrowsException<ArgumentException>(() => new Circle(radius));
        }

        [TestMethod]
        public void CalculateAreaTest()
        {
            var radius = 7.5;
            var circle = new Circle(radius);
            var expVal = Math.PI * Math.Pow(radius, 2);

            var area = circle.CalculateArea();
            
            Assert.AreEqual(expVal, area);
        }
    }
}
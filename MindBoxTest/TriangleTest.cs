using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBox;

namespace MindBoxTests
{
    [TestClass]
    public class TriangleTest
    {
        [DataTestMethod]
        [DataRow(1,2,3)]
        [DataRow(1,-2,4)]
        [DataRow(-1,1,3)]
        [DataRow(1,1,0)]
        public void CreateNotCorrectTriangleTest(double firstSide, double secondSide,double thirdSide)
        {
            Assert.ThrowsException<ArgumentException>(() => new Triangle(firstSide, secondSide, thirdSide));
        }

        [TestMethod]
        public void CalculateAreaTest()
        {
            var triangle = new Triangle(3, 4, 5);
            
            var result = 6;

            var area = triangle.CalculateArea();
            
            Assert.AreEqual(result, area);
        }
        
        [DataTestMethod]
        [DataRow(3,4,5)]
        public void TriangleIsRectangular(double firstSide, double secondSide, double thirdSide)
        {
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            
            Assert.IsTrue(triangle.IsRectangular);
        }
        
        [DataTestMethod]
        [DataRow(3,4,3)]
        public void TriangleIsNotRectangular(double firstSide, double secondSide, double thirdSide)
        {
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            
            Assert.IsFalse(triangle.IsRectangular);
        }
    }
}
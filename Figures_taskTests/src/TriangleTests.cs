using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures_task.src;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures_task.src.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        [DataRow(2, 3, 4, 2.9047375096555625)]
        [DataRow(4, 5, 6, 9.921567416492215)]
        [DataRow(3, 4, 5, 6)]
        public void TriangleSquareTest1(double s1, double s2, double s3, double expected)
        {
            Triangle triangle = new Triangle(s1, s2, s3);
            var square = triangle.Square();
            Assert.AreEqual(expected, square);
        }

        [TestMethod()]
        public void TriangleShouldNotExist1()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Triangle triangle = new Triangle(4, 2, 1);
            });
        }

        [TestMethod()]
        public void TriangleShouldNotExist2()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Triangle triangle = new Triangle(10, 2, 7);
            });
        }


        [TestMethod()]
        [DataRow(7, 200, 200.12246250733574)]
        [DataRow(8, 4, 8.94427190999916)]
        public void TriangleShouldBeRight(double side1, double side2, double side3)
        {
            double s3 = Math.Sqrt(side1 * side1 + side2 * side2);
            Triangle triangle = new Triangle(side1, side2, s3);
            Assert.IsTrue(triangle.IsRight());
        }

        [TestMethod()]
        [DataRow(7, 9, 15)]
        [DataRow(19, 15, 12)]
        public void TriangleShouldNotBeRight(double side1, double side2, double side3)
        {
            Triangle triangle = new Triangle(side1, side2, side3);
            Assert.IsFalse(triangle.IsRight());
        }
    }
}
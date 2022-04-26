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
    public class CircleTests
    {

        [TestMethod()]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(9)]
        [DataRow(5)]
        [DataRow(100)]
        [DataRow(500)]
        public void SquareTest(double radius)
        {
            Circle circle = new Circle(radius);
            Assert.AreEqual(Math.PI * radius * radius, circle.Square());
        }

        [TestMethod()]
        [DataRow(0)]
        [DataRow(-10)]
        public void ShouldThrowTest(double radius)
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Circle circle = new Circle(radius);
            });
        }
    }
}
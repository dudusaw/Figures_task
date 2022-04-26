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
    public class FigureDeciderTests
    {
        [TestMethod()]
        [DataRow("22", typeof(Circle))]
        [DataRow("22312", typeof(Circle))]
        [DataRow("1", typeof(Circle))]
        [DataRow("6", typeof(Circle))]
        [DataRow("10", typeof(Circle))]
        [DataRow("10 12 14", typeof(Triangle))]
        [DataRow("3 4 5", typeof(Triangle))]
        [DataRow("7 5 11", typeof(Triangle))]
        public void DecideTest(string data, Type type)
        {
            Assert.IsTrue(FigureDecider.Decide(data).GetType() == type);
        }
    }
}
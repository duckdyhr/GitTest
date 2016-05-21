using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp.Tests
{
    [TestClass()]
    public class ATests
    {
        [TestMethod()]
        public void AddTest()
        {
            double expected = 4;
            var a = new A();
            double actual = a.Add(1, 3);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod()]
        public void MinusTest()
        {
            double expected = -2;
            var a = new A();
            double actual = a.Minus(1, 3);
            Assert.AreEqual(expected, actual);
        }
    }
}
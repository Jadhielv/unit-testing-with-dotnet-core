using System;
using app;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace app_test
{
    [TestClass]
    public class CalculatorTest
    {
        [DataTestMethod]
        [DataRow(0)]
        [DataRow(1)]
        [DataRow(2)]
        public void Add(int value)
        {
            Console.WriteLine("Testing {0} + {0}", value);
            var actual = Calculator.Add(value, value);
            var expected = value + value;
            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        [Priority(1)]
        public void Subtract()
        {
            Assert.AreEqual(2, 2);
        }

        [TestMethod]
        [TestCategory("DivideAndMultiply")]
        public void Divide()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [TestCategory("DivideAndMultiply")]
        public void Multiply()
        {
            Assert.AreEqual(1, 1);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace app_test
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Add()
        {
            Assert.AreEqual(1, 1);
        }

        [TestMethod]
        [Priority(1)]
        public void Subtract()
        {
            Assert.AreEqual(1, 2);
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

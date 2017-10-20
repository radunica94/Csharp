using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCub
{
    [TestClass]
    public class Cub
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(192,GetNumber(1));
        }
        int GetNumber(int number)
        {
            return 0;
        }
    }
}

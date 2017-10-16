using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestChessTable
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(204,CalculateTheNumberOfSquares(8));
        }

        int CalculateTheNumberOfSquares(int value)
        {
            return 0;
        }
    }
}

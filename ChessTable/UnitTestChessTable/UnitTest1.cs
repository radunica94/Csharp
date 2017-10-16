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

        double CalculateTheNumberOfSquares(int value)
        {
            return Math.Pow(value-7, 2) + Math.Pow(value-6, 2) + Math.Pow(value-5, 2) + Math.Pow(value-4, 2) + Math.Pow(value-3, 2) + Math.Pow(value-2, 2) + Math.Pow(value-1, 2) + Math.Pow(value, 2);
        }
    }
}

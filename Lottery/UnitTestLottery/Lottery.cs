using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLottery
{
    [TestClass]
    public class Lottery
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0.00000007, CalculateTheWinningChance(49));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(24, CalculateTheWinningChance(4));
        }

        double CalculateTheWinningChance(int totalNumber)
        {
            return Factorial(totalNumber);
        }

        double Factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }
    }
}

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
            Assert.AreEqual(0.00000007, CalculateTheWinningChance(49,6));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(5, CalculateTheWinningChance(5,4));
        }

        double CalculateTheWinningChance(int totalNumber, int winningNumbers)
        {
            return Combination(totalNumber,winningNumbers);
        }

        double Factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }
        double Combination(int n , int k)
        {
            return Factorial(n) / (Factorial(k) * Factorial(n - k));
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLottery
{
    [TestClass]
    public class Lottery
    {
        [TestMethod]
        public void TestForFirstCategory()
        {
            Assert.AreEqual(0.00000007, CalculateTheWinningChance(49, 6, 6));
        }
        [TestMethod]
        public void TestForSecondCategory()
        {
            Assert.AreEqual(0.00001845, CalculateTheWinningChance(49,5,6));
        }
        [TestMethod]
        public void TestForThirdCategory()
        {
            Assert.AreEqual(0.00096862, CalculateTheWinningChance(49,4,6));
        }
        [TestMethod]
        public void TestForFiveOutOfFourty()
        {
            Assert.AreEqual(0.00000152, CalculateTheWinningChance(40,5,5));
        }

        double CalculateTheWinningChance(int totalNumber, int winningNumbers, int numbersPlayed)
        {
            double win = (Combination(numbersPlayed, winningNumbers) * Combination(totalNumber - numbersPlayed, numbersPlayed - winningNumbers)) / Combination(totalNumber, numbersPlayed);
            return Math.Round(win,8);
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

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
            Assert.AreEqual(0.00000007, CalculateTheWinningChance(49, 6));
        }

        double CalculateTheWinningChance(int totalNumber, int winningNumbers)
        {
            return 0;
        }

    }
}

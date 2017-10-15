using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestRent
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(108, CalculateDebts(100, 4));
        }

        double CalculateDebts(int rent , int delayedDays )
        {
            return GetDebt(rent, delayedDays) + rent;
        }

        double GetDebt(int rent , int delayedDays)
        {
            if (delayedDays >= 1 && delayedDays <= 10)
                return rent * 0.02 * delayedDays;
            if (delayedDays >= 11 && delayedDays <= 30)
                return rent * 0.05 * delayedDays;
            if (delayedDays >= 31 && delayedDays <= 40)
                return rent * 0.1 * delayedDays;
            else
                return rent;
        }

    }
}

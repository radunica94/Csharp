using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankRate
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void RateForFirstMonth()
        {
            decimal rate = CalculateBankRate(200, 2, 12, 1);
            Assert.AreEqual(102, rate);
        }

        [TestMethod]
        public void RateForSecondMonth()
        {
            decimal rate = CalculateBankRate(200, 2, 12, 2);
            Assert.AreEqual(101, rate);
        }

        [TestMethod]
        public void ThirdMonthRateForATenMonthCredit()
        {
            decimal rate = CalculateBankRate(200, 10, 12, 3);
            Assert.AreEqual(21.6m, rate);
        }


        decimal CalculateBankRate(decimal total, int perioadInMonths, decimal interestPerYear, int currentMonth)
        {
            decimal principal = total / perioadInMonths;
            decimal exactInterestPerMonth = interestPerYear / 12 / 100;
            decimal sold = total - (currentMonth - 1) * principal;
            return principal + sold * exactInterestPerMonth;
        }
    }
}

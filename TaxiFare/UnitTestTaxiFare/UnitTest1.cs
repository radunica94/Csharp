using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestTaxiFare
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DayTimeFareForShortDistances()
        {
                Assert.AreEqual(5, CalculateTaxiFare(1, 8));
        }

        decimal CalculateTaxiFare(int distanceInKm, int hour)
        {
            return distanceInKm * 5;
        }
    }
}

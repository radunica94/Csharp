using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestGoat
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void KgOfHay()
        {
            decimal total = CalculateHayKg(3, 5, 105, 7, 10);
            Assert.AreEqual(490, total);
        }
        

        decimal CalculateHayKg(int xDays , int yGoats, int zKg , int wDays , int qGoats)
        {

            //number of hay eaten by y goats in w days
            decimal hayInWDays = wDays * zKg / xDays;

            //return the number of hay eaten by q goats in w days;
            return hayInWDays*qGoats/yGoats;
        }

    }
}

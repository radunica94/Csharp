using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestLunch
{
    [TestClass]
    public class Lunch
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(12,CalculateLunchSchedule(6,4));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(4, CalculateLunchSchedule(4, 4));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(4, CalculateLunchSchedule(4, 2));
        }
        int CalculateLunchSchedule(int mySchedule, int friendsSchedule)
        {
            int product = mySchedule * friendsSchedule;
            if (mySchedule == friendsSchedule)
                return mySchedule;
            if (product % CalculateDifference(mySchedule, friendsSchedule) == 0)
                return product / CalculateDifference(mySchedule, friendsSchedule);
            return product;
        }

        private int CalculateDifference(int mySchedule, int friendsSchedule)
        {
            if (mySchedule > friendsSchedule)
                return mySchedule - friendsSchedule;
            return friendsSchedule - mySchedule;
        }
    }
}

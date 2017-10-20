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
            int sum = mySchedule * friendsSchedule;
            if (mySchedule == friendsSchedule)
                return mySchedule;
            if (sum % CalculateDifference(mySchedule, friendsSchedule) == 0)
                return sum / CalculateDifference(mySchedule, friendsSchedule);
            return sum;
        }

        private int CalculateDifference(int mySchedule, int friendsSchedule)
        {
            if (mySchedule > friendsSchedule)
                return mySchedule - friendsSchedule;
            return friendsSchedule - mySchedule;
        }
    }
}

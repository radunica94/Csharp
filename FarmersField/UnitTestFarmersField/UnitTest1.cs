using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFarmersField
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(592900,CalculateFieldSize(230,770000));
        }
        double CalculateFieldSize(int addedSize , int totalArea)
        {
            if(GetSideSize1(addedSize, GetDeltaValue(addedSize, totalArea)) > 0)
                return Math.Pow(GetSideSize1(addedSize, GetDeltaValue(addedSize, totalArea)), 2);
            return Math.Pow(GetSideSize2(addedSize, GetDeltaValue(addedSize, totalArea)), 2);
        }

        private static double GetDeltaValue(int addedSize, int totalArea)
        {
            return Math.Sqrt(Math.Pow(addedSize, 2) + 4 * totalArea);
        }

        private static double GetSideSize1(int addedSize, double delta)
        {
            return (-addedSize + delta) / 2;
        }
        private static double GetSideSize2(int addedSize, double delta)
        {
            return (-addedSize - delta) / 2;
        }
    }
}

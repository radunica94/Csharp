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
            double delta = Math.Sqrt(Math.Pow(addedSize, 2) + 4 * totalArea);
            
            return Math.Pow(GetSize(addedSize,delta), 2);
        }

        private static double GetSize(int addedSize, double delta)
        {
            return (-addedSize + delta) / 2;
        }
    }
}

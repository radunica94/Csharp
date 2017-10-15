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
            return 0;
        }
    }
}

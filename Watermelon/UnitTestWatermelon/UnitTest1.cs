using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestWatermelon
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("DA",CalculateMelonWeight(10));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("NU", CalculateMelonWeight(11));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("NU", CalculateMelonWeight(2));
        }

        string CalculateMelonWeight(int melonWeight)
        {
            if (melonWeight == 2)
                return "NU";
            if(melonWeight %2 == 0) 
                return "DA";
            return "NU";
        }
    }
}

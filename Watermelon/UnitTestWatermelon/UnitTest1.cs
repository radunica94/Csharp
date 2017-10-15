﻿using System;
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

        string CalculateMelonWeight(int melonWeight)
        {
            if(melonWeight %2 == 0) 
                return "DA";
            return "NU";
        }
    }
}

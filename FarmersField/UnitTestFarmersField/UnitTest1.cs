﻿using System;
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
            double delta = GetDeltaValue(addedSize, totalArea);
            double side = GetSideSize(addedSize, delta);
            return Math.Pow(side, 2);
        }

        private static double GetDeltaValue(int addedSize, int totalArea)
        {
            return Math.Sqrt(Math.Pow(addedSize, 2) + 4 * totalArea);
        }

        private static double GetSideSize(int addedSize, double delta)
        {
            return (-addedSize + delta) / 2;
        }
    }
}

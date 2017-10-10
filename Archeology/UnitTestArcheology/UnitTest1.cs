using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestArcheology
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double area = CalculateBuildingArea(0, 0, 2, 0, 1, 2);
            Assert.AreEqual(2, area);
        }

        [TestMethod]
        public void TestMethod2()
        {
            double area = CalculateBuildingArea(2, 0, 0, 0, 1, 2);
            Assert.AreEqual(2, area);
        }

        double CalculateBuildingArea(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double xy = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double xz = Math.Sqrt(Math.Pow(x3 - x1, 2) + Math.Pow(y3 - y1, 2));
            double yz = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));

            double p = (xy + xz + yz) / 2;

            double S = Math.Sqrt((p * (p - xy) * (p - xz) * (p - yz)));

            return S;
        }
    }
}

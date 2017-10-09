using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestParquet
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void PlateNumber()
        {
            double total = CalculateNumberOfParcquetPlates(17,4,2,1);
            Assert.AreEqual(40, total);
        }



        double CalculateNumberOfParcquetPlates(double roomLenght , double roomWidth , double plateLenght, double plateWidth)
        {
            double roomArea = roomLenght * roomWidth;
            double plateArea = plateLenght * plateWidth;
            return roomArea / (plateArea - plateArea * 0.15);
        }
    }
}

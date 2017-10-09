using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPavement
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double total = CalculateNumberOfStones(6, 6, 2);
            Assert.AreEqual(9, total);
        }

        [TestMethod]
        public void TestMethod2()
        {
            double total = CalculateNumberOfStones(6, 6, 4);
            Assert.AreEqual(4, total);
        }

        [TestMethod]
        public void TestMethod3()
        {
            double total = CalculateNumberOfStones(6, 6, 3);
            Assert.AreEqual(4, total);
        }

        [TestMethod]
        public void TestMethod4()
        {
            double total = CalculateNumberOfStones(10, 10, 2);
            Assert.AreEqual(25, total);
        }

        [TestMethod]
        public void TestMethod5()
        {
            double total = CalculateNumberOfStones(6, 5, 3);
            Assert.AreEqual(4, total);
        }

        [TestMethod]
        public void TestMethod6()
        {
            double total = CalculateNumberOfStones(4, 4, 4);
            Assert.AreEqual(1, total);
        }

        double CalculateNumberOfStones(double streetLenght, double streetWidth , double stoneDimension)
        {
            double result = 0;
            if(streetLenght % stoneDimension == 0 && streetWidth % stoneDimension == 0)
            {
                double lenght = streetLenght / stoneDimension;
                double widht = streetWidth / stoneDimension;
                result = lenght * widht;
            }
            else
            {
                double lenght = Math.Ceiling(streetLenght / stoneDimension);
                double widht = Math.Ceiling(streetWidth / stoneDimension);
                result = lenght*widht;
            }
            return result;        
        }
    }
}

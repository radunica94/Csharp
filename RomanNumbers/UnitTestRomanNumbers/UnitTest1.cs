using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestRomanNumbers
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("X", ConvertToRomanNumber(10));
        }

        string ConvertToRomanNumber(int numberToConvert)
        {
            string convertedNumber = null;


            return convertedNumber;
        }
    }
}

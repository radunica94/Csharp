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

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("XXII", ConvertToRomanNumber(22));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("C", ConvertToRomanNumber(100));
        }

        string ConvertToRomanNumber(int numberToConvert)
        {
            string[] hundredsLetters = { "", "C" };
            string[] tensLetters = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] onesLetters = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };

            string romanValue = "";
            int number;
            //numbers with 3 decimals
            number = numberToConvert / 100;
            romanValue += hundredsLetters[number];
            numberToConvert %= 100;

            //numbers with 2 decimals
            number = numberToConvert / 10;
            romanValue += tensLetters[number];
            numberToConvert %= 10;

            //numbers with one decimal
            romanValue += onesLetters[numberToConvert];

            return romanValue;
        }
    }
}

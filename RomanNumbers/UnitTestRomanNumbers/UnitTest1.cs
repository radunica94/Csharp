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

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("XCV", ConvertToRomanNumber(95));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual("LXI", ConvertToRomanNumber(61));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual("LXXV", ConvertToRomanNumber(75));
        }

        string ConvertToRomanNumber(int numberToConvert)
        {
            //string[] hundredsLetters = { "", "C" };
            //string[] tensLetters = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            //string[] onesLetters = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            //string romanValue = "";
            //int number;

            ////numbers with 3 decimals
            //number = numberToConvert / 100;
            //romanValue += hundredsLetters[number];
            //numberToConvert %= 100;

            ////numbers with 2 decimals
            //number = numberToConvert / 10;
            //romanValue += tensLetters[number];
            //numberToConvert %= 10;

            ////numbers with one decimal
            //romanValue += onesLetters[numberToConvert];

            int[] decimalNumbers = {100, 90, 50, 40, 10, 9, 5, 4, 1};
            string[] romanNumbers = {"C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            string result = "";

            for(int i =0; i < decimalNumbers.Length; i++)
            {
                while(decimalNumbers[i] <= numberToConvert)
                {
                    result += romanNumbers[i];
                    numberToConvert -= decimalNumbers[i];
                }
            }
           

            return result;
        }
    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestAnagrams
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestForOneLetter()
        {
            Assert.AreEqual(1,CalculateAnagrams("a"));
        }

        double CalculateAnagrams(string word)
        {
            return Factorial(word.Length);
        }

        double Factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }

        int RepeatingLetter()
        {
            return 0;
        }
    }
}

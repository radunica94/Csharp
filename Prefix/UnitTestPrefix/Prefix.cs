using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPrefix
{
    [TestClass]
    public class Prefix
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("aaa",FindThePrefix("aaab", "aaaabbaa"));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("aba", FindThePrefix("abab", "abaaabbaa"));
        }

        string FindThePrefix(string firstValue, string secondValue)
        {
            int prefixLenght = 0;

            for(int i = 0; i < Math.Min(firstValue.Length, secondValue.Length); i++)
            {
                if (firstValue[i] != secondValue[i])
                    break;
                prefixLenght++;
            }
            return firstValue.Substring(0, prefixLenght);
        }
    }
}

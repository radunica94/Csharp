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

        string FindThePrefix(string firstValue, string secondValue)
        {
            return "";
        }
    }
}

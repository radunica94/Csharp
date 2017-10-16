using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

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
            string similar = string.Join("", firstValue.TakeWhile((ch, i) => i < secondValue.Length && secondValue[i] == ch));
            return similar;
        }
    }
}

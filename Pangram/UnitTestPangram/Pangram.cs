using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestPangram
{
    [TestClass]
    public class Pangram
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(true,CheckForPangram("The quick brown fox jumps over the lazy dog"));
        }

        bool CheckForPangram(string sentence)
        {
            bool panagram = true;
            return panagram;
        }
    }
}

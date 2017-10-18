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
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(false, CheckForPangram("This is not a panagram"));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(false, CheckForPangram("My name is Radu"));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(true, CheckForPangram("We promptly judged antique ivory buckles for the next prize."));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual(true, CheckForPangram("Waltz, nymph, for quick jigs vex bud."));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual(true, CheckForPangram("Q-kelt vug dwarf combs jynx phiz."));
        }

        [TestMethod]
        public void TestMethod7()
        {
            Assert.AreEqual(false, CheckForPangram("Is this sentence a panagram?"));
        }

        [TestMethod]
        public void TestMethod8()
        {
            Assert.AreEqual(false, CheckForPangram("We promptly judged antique ivory buckles for the next year."));
        }

        bool CheckForPangram(string sentence)
        {
            string characters = "abcdefghijklmnopqrstuvwxyz";
            bool solution1 = true;
            for(int i =0; i < characters.Length; i++)
            {
                if (!sentence.ToLower().Contains(characters[i].ToString()))
                {                   
                    solution1 = false;
                    break;
                }
            }

            return solution1;
        }
    }
}

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
            bool[] letters = new bool[26];
            
            for(int i =0; i < sentence.Length; i++)
            {
                char character = char.ToUpper(sentence[i]);
                if(character>= 'A' && character <= 'Z')
                {
                    int position = character - 'A';
                    letters[position] = true;
                }
            }
            for (int i = 0; i < letters.Length; i++)
                if (!letters[i])
                    return false;
            return true;
        }
    }
}

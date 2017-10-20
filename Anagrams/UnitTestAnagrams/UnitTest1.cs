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

        [TestMethod]
        public void TestForFourLetters()
        {
            Assert.AreEqual(24, CalculateAnagrams("abcd"));
        }

        [TestMethod]
        public void TestForEightLetters()
        {
            Assert.AreEqual(40320, CalculateAnagrams("abcdefgh"));
        }

        [TestMethod]
        public void TestForSameLetter()
        {
            Assert.AreEqual(1, CalculateAnagrams("aaaa"));
        }
        [TestMethod]
        public void TestForMoreRepeatingLetters()
        {
            Assert.AreEqual(6, CalculateAnagrams("aabb"));
        }
        int CalculateAnagrams(string word)
        {
            int fact = 1;
            for (int i = 'a'; i <= 'z'; i++)
                fact *= Factorial(FindRepeatingLetter(i, word));
            return Factorial(word.Length)/fact;
        }

        int Factorial(int i)
        {
            if (i <= 1)
                return 1;
            return i * Factorial(i - 1);
        }

        int FindRepeatingLetter(int letterToCompare, string word)
        {
            int index = 0;
            for (int i = 0; i < word.Length; i++)
                if (letterToCompare == word[i])
                    index++;
            return index;
        }
    }
}

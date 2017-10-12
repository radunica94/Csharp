using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestSportiv
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NumberOfRepetitions()
        {
            int totalRepetitions = CalculateRepetition(5);
            Assert.AreEqual(25,totalRepetitions);   
        }

        [TestMethod]
        public void NumberOfRepetitions2()
        {
            int totalRepetitions = CalculateRepetition(10);
            Assert.AreEqual(100, totalRepetitions);
        }

        //firstNumberOfRepetitions reprezinta numarul de N repetitii la N runde
        //secondNumberOfRepetitions reprezinta numarul de 1/runda de repetitii , care este N-1

        int CalculateRepetition(int numberOfRepetitions)
        {
            return numberOfRepetitions*numberOfRepetitions;
        }
    }
}

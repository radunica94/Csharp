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
            int totalRepetitions = CalculateRepetition(5, 4);
            Assert.AreEqual(9,totalRepetitions);   
        }

        //firstNumberOfRepetitions reprezinta numarul de N repetitii la N runde
        //secondNumberOfRepetitions reprezinta numarul de 1/runda de repetitii , care este N-1

        int CalculateRepetition(int firstNumberOfRepetitions, int secondNumberOfRepetitions)
        {
            return firstNumberOfRepetitions + secondNumberOfRepetitions;
        }
    }
}

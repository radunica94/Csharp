using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestMushroom
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NumberOfRedMushrooms()
        {
            decimal total = CalculateNumberOfRedmMushrooms(100, 3);
            Assert.AreEqual(75, total);
        }


        //xNumberOfMushrooms este x-ul din cerinta , rosii is de x ori mai multe.

        decimal CalculateNumberOfRedmMushrooms(int totalMushrooms, int xNumberOfMushrooms)
        {
            return (totalMushrooms * xNumberOfMushrooms) / (1 + xNumberOfMushrooms);
        }
    }
}

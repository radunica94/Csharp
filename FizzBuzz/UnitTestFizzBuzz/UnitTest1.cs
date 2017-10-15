using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestFizzBuzz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("Fizz", FizzBuzz(9));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("Buzz", FizzBuzz(20));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzz(15));
        }
        string FizzBuzz(int value)
        {
            if (value % 3 == 0)
                return "Fizz";
            else
                return "NoFizzBuzz";
        }
    }
}

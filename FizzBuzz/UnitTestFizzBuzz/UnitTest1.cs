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

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("Fizz", FizzBuzz(21));
        }

        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual("NoFizzBuzz", FizzBuzz(22));
        }

        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual("FizzBuzz", FizzBuzz(75));
        }

        string FizzBuzz(int value)
        {
            if (value % 3 == 0 && value % 5 == 0)
                return "FizzBuzz";
            if (value % 3 == 0)
                return "Fizz";
            if (value % 5 == 0)
                return "Buzz";            
            else
                return "NoFizzBuzz";
        }
    }
}

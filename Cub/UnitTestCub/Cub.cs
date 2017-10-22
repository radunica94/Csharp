using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestCub
{
    [TestClass]
    public class Cub
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(192,GetNumber(1));
        }
        int GetNumber(int number)
        {
            int index = 0;
            for(int i = 0; i<= 1000; i++)
            {
                if (Math.Pow(i, 3) % 1000 == 888)
                {
                    index++;
                    if (index == number)
                        return i;
                }
            }
            return 0;
        }
    }
}

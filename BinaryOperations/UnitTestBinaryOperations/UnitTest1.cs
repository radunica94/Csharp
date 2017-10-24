using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBinaryOperations
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConvertToBinary()
        {
            CollectionAssert.AreEqual(new byte[]{1,1},ConvertToBinary(3));
        }

        byte[] ConvertToBinary(int number)
        {
            return new byte[] { 1,1};
        }
    }
}

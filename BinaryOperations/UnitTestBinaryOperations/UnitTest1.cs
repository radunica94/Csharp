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
            byte[] value = new byte[0];
            int i = 0;
            while (number > 0) 
            {
                Array.Resize(ref value, i + 1);
                value[i] = (byte)(number % 2);
                number /= 2;
                i++;
            }
            return ReverseBinary(value);
        }

        byte[] ReverseBinary(byte[] number)
        {
            byte[] value = new byte[number.Length];
            for (int i = 0; i < value.Length; i++)
            {
                value[i] = number[number.Length - i - 1];
            }
            return value;
        }
    }
}

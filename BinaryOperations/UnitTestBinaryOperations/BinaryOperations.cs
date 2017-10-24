using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestBinaryOperations
{
    [TestClass]
    public class BinaryOperations
    {
        [TestMethod]
        public void TestForConvertToBinary()
        {
            CollectionAssert.AreEqual(new byte[]{1,1},ConvertToBinary(3));
        }

        [TestMethod]
        public void TestForConvertToBinary1()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1,1,1 }, ConvertToBinary(15));
        }

        [TestMethod]
        public void TestForANDOperator()
        {
            CollectionAssert.AreEqual(new byte[] {0,0,1}, LogicOperations(ConvertToBinary(1), ConvertToBinary(7), "AND"));
        }
        [TestMethod]
        public void TestForOROperator()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1 }, LogicOperations(ConvertToBinary(1), ConvertToBinary(7), "OR"));
        }
        [TestMethod]
        public void TestForXOROperator()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0 }, LogicOperations(ConvertToBinary(1), ConvertToBinary(7), "XOR"));
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
        byte[] LogicOperations(byte[] firstNumber, byte[] secondNumber, string operation)
        {
            byte[] result = new byte[Math.Max(firstNumber.Length, secondNumber.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                byte firstNumberByte = AddZero(firstNumber, i);
                byte secondNumberByte = AddZero(secondNumber, i);
                result[i] = LogicOperations(firstNumberByte, secondNumberByte, operation);
            }
            return ReverseBinary(result);
        }
        byte ANDOperator(byte firstValue, byte secondValue)
        {
            if (firstValue == secondValue && firstValue == 1) 
                return 1;
            return 0;
        }
        byte OROperator(byte firstValue, byte secondValue)
        {
            if (firstValue == 1 || secondValue == 1)
                return 1;
            return 0;
        }
        byte XOROperator(byte firstValue, byte secondValue)
        {
            if (firstValue != secondValue)
                return 1;
            return 0;
        }
        byte LogicOperations(byte firstValue , byte secondValue, string operation)
        {
            switch (operation)
            {
                case "AND":
                    return ANDOperator(firstValue, secondValue);
                case "OR":
                    return OROperator(firstValue, secondValue);
                case "XOR":
                    return XOROperator(firstValue, secondValue);
            }
            return 0;
        }
        byte AddZero(byte[]number,int position)
        {
            if (position >= (number.Length))
                return (byte)0;
            return number[number.Length - position - 1];
        }

    }
}

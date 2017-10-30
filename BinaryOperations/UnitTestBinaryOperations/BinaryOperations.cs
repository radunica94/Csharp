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

        [TestMethod]
        public void TestForNotOperator()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 0, 0 }, NotOperator(ConvertToBinary(7)));
        }
        [TestMethod]
        public void TestForNotOperator1()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 0 }, NotOperator(ConvertToBinary(5)));
        }
        [TestMethod]
        public void TestForShiftOperator()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 1}, ShiftOperator(ConvertToBinary(7),"Right"));
        }
        [TestMethod]
        public void TestForShiftOperator1()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0 }, ShiftOperator(ConvertToBinary(7),"Left"));
        }
        [TestMethod]
        public void TestForLessThanOperator()
        {
            Assert.AreEqual(true, LessThanOperator(ConvertToBinary(1), ConvertToBinary(7)));
        }
        [TestMethod]
        public void TestForLessThanOperator1()
        {
            Assert.AreEqual(false, LessThanOperator(ConvertToBinary(7), ConvertToBinary(1)));
        }
        [TestMethod]
        public void TestForAddOperator()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1 }, AddOperator(ConvertToBinary(4), ConvertToBinary(3),2));
        }
        [TestMethod]
        public void TestForAddOperator1()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 1, 1, 0 }, AddOperator(ConvertToBinary(15), ConvertToBinary(15), 2));
        }
        [TestMethod]
        public void TestForSubtractOperator()
        {
            CollectionAssert.AreEqual(new byte[] { 0, 1, 0 }, SubtractOperator(ConvertToBinary(7), ConvertToBinary(5)));
        }
        [TestMethod]
        public void TestForSubtractOperator1()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 0, 1, 0 }, SubtractOperator(ConvertToBinary(15), ConvertToBinary(5)));
        }
        [TestMethod]
        public void TestForSubtractOperator2()
        {
            CollectionAssert.AreEqual(new byte[] { 1, 1, 0, 0 }, SubtractOperator(ConvertToBinary(15), ConvertToBinary(3)));
        }
        [TestMethod]
        public void TestForMultiplyOperator()
        {
            CollectionAssert.AreEqual(new byte[] {1, 1, 0, 1, 1, 1, 0 }, MultiplyOperator(ConvertToBinary(10), ConvertToBinary(11),2));
        }

        [TestMethod]
        public void TestForNotEqual()
        {
            Assert.AreEqual(true, NotEqual(ConvertToBinary(10), ConvertToBinary(11)));
        }
        [TestMethod]
        public void TestForEqual()
        {
            Assert.AreEqual(true, Equal(ConvertToBinary(10), ConvertToBinary(10)));
        }
        [TestMethod]
        public void TestForGraterThan()
        {
            Assert.AreEqual(false, GraterThan(ConvertToBinary(10), ConvertToBinary(11)));
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
        byte[] LogicOperations(byte[] firstValue, byte[] secondValue, string operation)
        {
            byte[] result = new byte[Math.Max(firstValue.Length, secondValue.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                byte firstValueByte = AddZero(firstValue, i);
                byte secondValueByte = AddZero(secondValue, i);
                result[i] = LogicOperations(firstValueByte, secondValueByte, operation);
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

        byte[] NotOperator(byte[] value)
        {
            byte[] result = new byte[value.Length];
            for(int i = 0; i < value.Length; i++)
            {
                if (value[i] == 1)
                    result[i] = 0;
                else
                    result[i] = 1;
            }
            return result;
        }
       
        byte[] ShiftOperator(byte[] value, string direction)
        {
            switch (direction)
            {
                case "Right":
                    for (int i = value.Length - 1; i < 0; i--)
                        value[i] = value[i - 1];
                    value[0] = 0;
                    break;
                case "Left":
                    for (int i = 0; i < value.Length - 1; i++)
                        value[i] = value[i + 1];
                    value[value.Length - 1] = 0;
                    break;
            }
            return value;
        }

        bool LessThanOperator(byte[] firstValue , byte[] secondValue)
        {
            for (int i = 0; i < Math.Max(firstValue.Length, secondValue.Length); i++)
                if (AddZero(firstValue, i) != AddZero(secondValue, i))
                    return (AddZero(firstValue, i) < AddZero(secondValue, i));
                return false;
        }

        byte[] AddOperator(byte[] firstValue, byte[] secondValue,int conversion)
        {
            byte[] result = new byte[Math.Max(firstValue.Length, secondValue.Length)];
            int carry = 0;
            for (int i = 0; i < result.Length; i++)
            {
                int addition = AddZero(firstValue, i) + AddZero(secondValue, i) + carry;
                result[i] = (byte)(addition % conversion);
                carry = addition / conversion;
            }
            if (carry != 0)
            {
                Array.Resize(ref result, result.Length + 1);
                result[result.Length - 1] = (byte)carry;
            }
            return ReverseBinary(result);
        }
        byte[] SubtractOperator(byte[] firstValue, byte[] secondValue)
        {
            byte[] result = new byte[Math.Max(firstValue.Length, secondValue.Length)];
            for(int i = 0; i < result.Length; i++)
            {
                int subtraction = AddZero(firstValue, i) - AddZero(secondValue, i);
                result[i] = (byte)(subtraction);
            }
            return ReverseBinary(result);
        }
        byte[] MultiplyOperator(byte[] firstValue , byte[] secondValue,int conversion) 
        {
            byte[] result = new byte[Math.Max(firstValue.Length, secondValue.Length)];
            while(NotEqual(firstValue,ConvertToBinary(0)))
            {
                result = AddOperator(result,firstValue,conversion);
                secondValue = SubtractOperator(secondValue,ConvertToBinary(1));
            }

            return result;
        }

        bool NotEqual(byte[] firstValue, byte[] secondValue)
        {
            return (GraterThan(firstValue, secondValue) || GraterThan(secondValue,firstValue));
        }
        bool GraterThan(byte[] firstValue, byte[] secondValue)
        {
            for (int i = 0; i < Math.Max(firstValue.Length, secondValue.Length); i++)
                if (AddZero(firstValue, i) > AddZero(secondValue, i))
                    return true;
            return false;
        }
        bool Equal(byte[] firstValue, byte[] secondValue)
        {
            for (int i = 0; i < Math.Max(firstValue.Length, secondValue.Length); i++)
                if (AddZero(firstValue, i) == AddZero(secondValue, i))
                    return true;
            return false;
        }
    }
}

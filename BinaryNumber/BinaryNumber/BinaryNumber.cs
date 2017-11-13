using System;
using System.Collections.Generic;
using System.Text;
namespace BinaryNumber
{
    class BinaryNumber
    {
        private byte[] value;

        public BinaryNumber(int number)
        {
            this.value = ConvertToBinary(number);
        }
        public BinaryNumber(byte[] number)
        {
            this.value = number;
        }
        private byte[] ConvertToBinary(int value)
        {
            byte[] binary = new byte[0];
            int i = 0;
            while (value > 0)
            {
                Array.Resize(ref binary, i + 1);
                binary[i] = (byte)(value % 2);
                value /= 2;
                i++;
            }
            return ReverseBinary(binary);
        }
        private byte[] ReverseBinary(byte[] value)
        {
            byte[] binary = new byte[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                binary[i] = value[value.Length - i - 1];
            }
            return binary;
        }
        private byte[] LogicOperation(byte[] firstValue, byte[] secondValue, string operation)
        {
            byte[] result = new byte[Math.Max(firstValue.Length, secondValue.Length)];
            for (int i = 0; i < result.Length; i++)
            {
                byte firstValueByte = AddZero(firstValue, i);
                byte secondValueByte = AddZero(secondValue, i);
                result[i] = LogicOperation(firstValueByte, secondValueByte, operation);
            }
            return ReverseBinary(result);
        }
        //And
        private byte ANDOperator(byte firstValue, byte secondValue)
        {
            if (firstValue == secondValue && firstValue == 1)
                return 1;
            return 0;
        }
        public BinaryNumber And(BinaryNumber secondValue)
        {
            var result = LogicOperation(value, secondValue.value, "AND");
            BinaryNumber binaryNumber = new BinaryNumber(result);
            return binaryNumber;
        }
        //Or
        private byte OROperator(byte firstValue, byte secondValue)
        {
            if (firstValue == 1 || secondValue == 1)
                return 1;
            return 0;
        }
        public BinaryNumber Or(BinaryNumber secondValue)
        {
            var result = LogicOperation(value, secondValue.value, "OR");
            BinaryNumber binaryNumber = new BinaryNumber(result);
            return binaryNumber;
        }
        //Xor
        private byte XOROperator(byte firstValue, byte secondValue)
        {
            if (firstValue != secondValue)
                return 1;
            return 0;
        }
        public BinaryNumber Xor(BinaryNumber secondValue)
        {
            var result = LogicOperation(value, secondValue.value, "XOR");
            BinaryNumber binaryNumber = new BinaryNumber(result);
            return binaryNumber;
        }
        //LogicOperation
        private byte LogicOperation(byte firstValue, byte secondValue, string operation)
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
        private byte AddZero(byte[] number, int position)
        {
            if (position >= (number.Length))
                return (byte)0;
            return number[number.Length - position - 1];
        }
        private byte[] NotOperation(byte[] value)
        {
            byte[] result = new byte[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                if (value[i] == 1)
                    result[i] = 0;
                else
                    result[i] = 1;
            }
            return result;
        }
        //Right shift
        private byte[] RightShift(byte[] value, byte shiftsNr)
        {
            byte[] result = new byte[value.Length - 2];
            for (int i = 0; i < value.Length - 2; i++)
            {
                result[i] = value[i];
            }
            return result;
        }
        public BinaryNumber ShiftR(byte shiftsNr)
        {
            var result = RightShift(value, shiftsNr);
            BinaryNumber binaryNumber = new BinaryNumber(result);
            return binaryNumber;
        }
        //Left Shift 
        private byte[] LeftShift(byte[] value, byte shiftsNr)
        {
            byte[] newValue = new byte[value.Length + shiftsNr];
            for (int i = 0; i < value.Length; i++)
            {
                newValue[i] = value[i];
            }
            for (int i = value.Length; i < value.Length + shiftsNr; i++)
            {
                newValue[i] = 0;
            }
            return newValue;
        }
        public BinaryNumber ShiftL(byte shiftsNr)
        {
            var result = LeftShift(value, shiftsNr);
            BinaryNumber binaryNumber = new BinaryNumber(result);
            return binaryNumber;
        }
        //AddOperation
        private byte[] AddOperation(byte[] firstValue, byte[] secondValue, int conversion)
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
        public BinaryNumber Add(BinaryNumber secondValue, int conversion)
        {
            var result = AddOperation(value, secondValue.value, conversion);
            BinaryNumber binaryNumber = new BinaryNumber(result);
            return binaryNumber;
        }
        //SubtractOperation
        private byte[] SubtractOperation(byte[] firstValue, byte[] secondValue, int conversion)
        {
            byte[] result = new byte[Math.Max(firstValue.Length, secondValue.Length)];
            int carry = 0;
            for (int i = 0; i < result.Length; i++)
            {
                int subtraction = conversion + AddZero(firstValue, i) - AddZero(secondValue, i) - carry;
                result[i] = (byte)(subtraction % conversion);
                carry = subtraction < conversion ? 1 : 0;
            }
            return ReverseBinary(result);
        }
        public BinaryNumber Sub(BinaryNumber secondValue, int conversion)
        {
            var result = SubtractOperation(value, secondValue.value, conversion);
            BinaryNumber binaryNumber = new BinaryNumber(result);
            return binaryNumber;
        }
        //NotEqual Function
        private bool NotEqual(byte[] firstValue, byte[] secondValue)
        {
            return (GraterThan(firstValue, secondValue) || GraterThan(secondValue, firstValue));
        }
        public bool NotEqual(BinaryNumber secondValue)
        {
            if (NotEqual(value, secondValue.value))
                return true;
            return false;
        }
        //GraterThan Function
        private bool GraterThan(byte[] firstValue, byte[] secondValue)
        {
            for (int i = 0; i < Math.Max(firstValue.Length, secondValue.Length); i++)
                if (AddZero(firstValue, i) > AddZero(secondValue, i))
                    return true;
            return false;
        }
        public bool GraterThan(BinaryNumber secondValue)
        {
            if (GraterThan(value, secondValue.value))
                return true;
            return false;
        }
        //Equal Function
        private bool Equal(byte[] firstValue, byte[] secondValue)
        {
            for (int i = 0; i < Math.Max(firstValue.Length, secondValue.Length); i++)
                if (AddZero(firstValue, i) != AddZero(secondValue, i))
                    return false;
            return true;
        }
        public bool Equal(BinaryNumber secondValue)
        {
            if (Equal(value, secondValue.value))
                return true;
            return false;
        }
        //MultiplyOperation
        private byte[] MultiplyOperation(byte[] firstValue, byte[] secondValue, int conversion)
        {
            byte[] result = new byte[Math.Max(firstValue.Length, secondValue.Length)];
            while (NotEqual(secondValue, ConvertToBinary(0)))
            {
                result = AddOperation(result, firstValue, conversion);
                secondValue = SubtractOperation(secondValue, ConvertToBinary(1), conversion);
            }
            return result;
        }
        public BinaryNumber Multiply(BinaryNumber secondValue, int conversion)
        {
            var result = MultiplyOperation(value, secondValue.value, conversion);
            BinaryNumber binaryNumber = new BinaryNumber(result);
            return binaryNumber;
        }
        //DivideOperation
        private byte[] DivideOperation(byte[] firstValue, byte[] secondValue, int conversion)
        {
            int divizor = 0;
            while (NotEqual(firstValue, ConvertToBinary(0)))
            {
                firstValue = SubtractOperation(firstValue, secondValue, conversion);
                divizor++;
            }
            return ConvertIntoBase(divizor, conversion);
        }
        public BinaryNumber Divide(BinaryNumber secondValue, int conversion)
        {
            var result = DivideOperation(value, secondValue.value, conversion);
            BinaryNumber binaryNumber = new BinaryNumber(result);
            return binaryNumber;
        }
        //ConvertIntoBase
        private byte[] ConvertIntoBase(double value, int conversion)
        {
            byte[] result = new byte[0];
            int i = 0;
            while (value > 0)
            {
                Array.Resize(ref result, i + 1);
                result[i] = (byte)(value % conversion);
                value = (int)value / conversion;
                i++;
            }
            return ReverseBinary(result);
        }
    }
}

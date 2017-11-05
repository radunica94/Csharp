using System;
using System.Collections.Generic;
using System.Text;

namespace OperatingWitchBinaryNumbers
{
    class BinaryNumbers
    {
       public BinaryNumbers()
       {

       }

        public byte[] ConvertToBinary(int value)
        {
            byte[] binary = new byte[0];
            int i = 0;
            while(value > 0)
            {
                Array.Resize(ref binary, i + 1);
                binary[i] = (byte)(value % 2);
                value /= 2;
                i++;
            }
            return ReverseBinary(binary);
        }
        public byte[] ReverseBinary(byte[] value)
        {
            byte[] binary = new byte[value.Length];
            for (int i = 0; i < value.Length; i++)
            {
                binary[i] = value[value.Length - i - 1];
            }
            return binary;
        }
        public byte[] LogicOperation(byte[] firstValue, byte[] secondValue, string operation)
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
        public byte ANDOperator(byte firstValue, byte secondValue)
        {
            if (firstValue == secondValue && firstValue == 1)
                return 1;
            return 0;
        }
        public byte OROperator(byte firstValue, byte secondValue)
        {
            if (firstValue == 1 || secondValue == 1)
                return 1;
            return 0;
        }
        public byte XOROperator(byte firstValue, byte secondValue)
        {
            if (firstValue != secondValue)
                return 1;
            return 0;
        }

        public byte LogicOperation(byte firstValue, byte secondValue, string operation)
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
        public byte AddZero(byte[] number, int position)
        {
            if (position >= (number.Length))
                return (byte)0;
            return number[number.Length - position - 1];
        }

        public byte[] NotOperation(byte[] value)
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

        public byte[] ShiftOperation(byte[] value, string direction)
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

        public byte[] AddOperation(byte[] firstValue, byte[] secondValue, int conversion)
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
        public byte[] SubtractOperation(byte[] firstValue, byte[] secondValue, int conversion)
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
        public bool NotEqual(byte[] firstValue, byte[] secondValue)
        {
            return (GraterThan(firstValue, secondValue) || GraterThan(secondValue, firstValue));
        }
        public bool GraterThan(byte[] firstValue, byte[] secondValue)
        {
            for (int i = 0; i < Math.Max(firstValue.Length, secondValue.Length); i++)
                if (AddZero(firstValue, i) > AddZero(secondValue, i))
                    return true;
            return false;
        }
        public bool Equal(byte[] firstValue, byte[] secondValue)
        {
            for (int i = 0; i < Math.Max(firstValue.Length, secondValue.Length); i++)
                if (AddZero(firstValue, i) == AddZero(secondValue, i))
                    return true;
            return false;
        }
    }
}

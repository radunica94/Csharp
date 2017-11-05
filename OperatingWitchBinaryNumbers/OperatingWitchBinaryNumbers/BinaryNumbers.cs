﻿using System;
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
        public byte[] LogicOperations(byte[] firstValue, byte[] secondValue, string operation)
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
        public byte LogicOperations(byte firstValue, byte secondValue, string operation)
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
    }
}
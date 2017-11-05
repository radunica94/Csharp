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
    }
}

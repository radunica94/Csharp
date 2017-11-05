using System;
using System.Collections.Generic;
using Xunit;

namespace OperatingWitchBinaryNumbers
{
    public class BinaryNumbersTest
    {
        [Fact]
        public void ConvertThreeToBinary()
        {
            var firstValue = new BinaryNumbers();
            Assert.Equal(new byte[] { 1, 1 }, firstValue.ConvertToBinary(3));
        }

    }
}

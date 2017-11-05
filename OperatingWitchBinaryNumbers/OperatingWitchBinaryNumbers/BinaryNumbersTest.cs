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
        [Fact]
        public void ConvertFifteenToBinary()
        {
            var firstValue = new BinaryNumbers();
            Assert.Equal(new byte[] { 1, 1, 1, 1 }, firstValue.ConvertToBinary(15));
        }
        [Fact]
        public void ANDOperator()
        {
            var firstValue = new BinaryNumbers();
            var secondValue = new BinaryNumbers();
            var result = new BinaryNumbers();
            Assert.Equal(new byte[] { 0, 0, 1 }, result.LogicOperations(firstValue.ConvertToBinary(1), secondValue.ConvertToBinary(7), "AND"));
        }
        [Fact]
        public void OROperator()
        {
            var firstValue = new BinaryNumbers();
            var secondValue = new BinaryNumbers();
            var result = new BinaryNumbers();
            Assert.Equal(new byte[] { 1, 1, 1 }, result.LogicOperations(firstValue.ConvertToBinary(1), secondValue.ConvertToBinary(7), "OR"));
        }
        [Fact]
        public void XOROperator()
        {
            var firstValue = new BinaryNumbers();
            var secondValue = new BinaryNumbers();
            var result = new BinaryNumbers();
            Assert.Equal(new byte[] { 1, 1, 0 }, result.LogicOperations(firstValue.ConvertToBinary(1), secondValue.ConvertToBinary(7), "XOR"));
        }
    }
}

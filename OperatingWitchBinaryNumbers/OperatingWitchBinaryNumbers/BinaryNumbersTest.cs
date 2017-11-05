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
            Assert.Equal(new byte[] { 0, 0, 1 }, result.LogicOperation(firstValue.ConvertToBinary(1), secondValue.ConvertToBinary(7), "AND"));
        }
        [Fact]
        public void OROperator()
        {
            var firstValue = new BinaryNumbers();
            var secondValue = new BinaryNumbers();
            var result = new BinaryNumbers();
            Assert.Equal(new byte[] { 1, 1, 1 }, result.LogicOperation(firstValue.ConvertToBinary(1), secondValue.ConvertToBinary(7), "OR"));
        }
        [Fact]
        public void XOROperator()
        {
            var firstValue = new BinaryNumbers();
            var secondValue = new BinaryNumbers();
            var result = new BinaryNumbers();
            Assert.Equal(new byte[] { 1, 1, 0 }, result.LogicOperation(firstValue.ConvertToBinary(1), secondValue.ConvertToBinary(7), "XOR"));
        }
        [Fact]
        public void NOTOperatorFirstTest()
        {
            var value = new BinaryNumbers();
            var result = new BinaryNumbers();
            Assert.Equal(new byte[] { 0, 0, 0 }, result.NotOperation(value.ConvertToBinary(7)));
        }
        [Fact]
        public void NOTOperatorSecondTest()
        {
            var value = new BinaryNumbers();
            var result = new BinaryNumbers();
            Assert.Equal(new byte[] { 0, 1, 0 }, result.NotOperation(value.ConvertToBinary(5)));
        }
        [Fact]
        public void ShiftRightOperator()
        {
            var value = new BinaryNumbers();
            var result = new BinaryNumbers();
            Assert.Equal(new byte[] { 0,1,1}, result.ShiftOperation(value.ConvertToBinary(7), "Right"));
        }
        [Fact]
        public void ShiftLeftOperator()
        {
            var value = new BinaryNumbers();
            var result = new BinaryNumbers();
            Assert.Equal(new byte[] { 1, 1, 0 }, result.ShiftOperation(value.ConvertToBinary(7), "Left"));
        }
        [Fact]
        public void ForPlusThree()
        {
            var firstValue = new BinaryNumbers();
            var secondValue = new BinaryNumbers();
            var result = new BinaryNumbers();
            Assert.Equal(new byte[] { 1, 1, 1 }, result.AddOperation(firstValue.ConvertToBinary(4), secondValue.ConvertToBinary(3), 2));
        }
        [Fact]
        public void FifteenPlusFiFteen()
        {
            var firstValue = new BinaryNumbers();
            var secondValue = new BinaryNumbers();
            var result = new BinaryNumbers();
            Assert.Equal(new byte[] { 1, 1, 1, 1, 0 }, result.AddOperation(firstValue.ConvertToBinary(15), secondValue.ConvertToBinary(15), 2));
        }
    }
}

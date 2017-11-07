using System;
using Xunit;

namespace BinaryNumber
{
    public class BinaryNumberTest
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
                Assert.Equal(new byte[] { 0, 1, 1 }, result.ShiftOperation(value.ConvertToBinary(7), "Right"));
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
            [Fact]
            public void SevenMinusFive()
            {
                var firstValue = new BinaryNumbers();
                var secondValue = new BinaryNumbers();
                var result = new BinaryNumbers();
                Assert.Equal(new byte[] { 0, 1, 0 }, result.SubtractOperation(firstValue.ConvertToBinary(7), secondValue.ConvertToBinary(5), 2));
            }
            [Fact]
            public void FifteenMinusFive()
            {
                var firstValue = new BinaryNumbers();
                var secondValue = new BinaryNumbers();
                var result = new BinaryNumbers();
                Assert.Equal(new byte[] { 1, 0, 1, 0 }, result.SubtractOperation(firstValue.ConvertToBinary(15), secondValue.ConvertToBinary(5), 2));
            }
            [Fact]
            public void FifteenMinusThree()
            {
                var firstValue = new BinaryNumbers();
                var secondValue = new BinaryNumbers();
                var result = new BinaryNumbers();
                Assert.Equal(new byte[] { 1, 1, 0, 0 }, result.SubtractOperation(firstValue.ConvertToBinary(15), secondValue.ConvertToBinary(3), 2));
            }
            [Fact]
            public void NotEqual()
            {
                var firstValue = new BinaryNumbers();
                var secondValue = new BinaryNumbers();
                var result = new BinaryNumbers();
                Assert.Equal(true, result.NotEqual(firstValue.ConvertToBinary(10), secondValue.ConvertToBinary(11)));
            }
            public void Equal()
            {
                var firstValue = new BinaryNumbers();
                var secondValue = new BinaryNumbers();
                var result = new BinaryNumbers();
                Assert.Equal(true, result.NotEqual(firstValue.ConvertToBinary(10), secondValue.ConvertToBinary(10)));
            }
            public void GraterThan()
            {
                var firstValue = new BinaryNumbers();
                var secondValue = new BinaryNumbers();
                var result = new BinaryNumbers();
                Assert.Equal(true, result.NotEqual(firstValue.ConvertToBinary(12), secondValue.ConvertToBinary(11)));
            }
            [Fact]
            public void TenTimesTwenty()
            {
                var firstValue = new BinaryNumbers();
                var secondValue = new BinaryNumbers();
                var result = new BinaryNumbers();
                Assert.Equal(result.ConvertToBinary(10 * 20), result.MultiplyOperation(firstValue.ConvertToBinary(10), secondValue.ConvertToBinary(20), 2));
            }
            [Fact]
            public void FourTimesFour()
            {
                var firstValue = new BinaryNumbers();
                var secondValue = new BinaryNumbers();
                var result = new BinaryNumbers();
                Assert.Equal(result.ConvertToBinary(4 * 4), result.MultiplyOperation(firstValue.ConvertToBinary(4), secondValue.ConvertToBinary(4), 2));
            }
            [Fact]
            public void TenTimesEleven()
            {
                var firstValue = new BinaryNumbers();
                var secondValue = new BinaryNumbers();
                var result = new BinaryNumbers();
                Assert.Equal(result.ConvertToBinary(10 * 11), result.MultiplyOperation(firstValue.ConvertToBinary(10), secondValue.ConvertToBinary(11), 2));
            }
            [Fact]
            public void TenTimesFive()
            {
                var firstValue = new BinaryNumbers();
                var secondValue = new BinaryNumbers();
                var result = new BinaryNumbers();
                Assert.Equal(result.ConvertToBinary(10 * 5), result.MultiplyOperation(firstValue.ConvertToBinary(10), secondValue.ConvertToBinary(5), 2));
            }
            [Fact]
            public void NineDividedIntoThree()
            {
                var firstValue = new BinaryNumbers();
                var secondValue = new BinaryNumbers();
                var result = new BinaryNumbers();
                Assert.Equal(result.ConvertToBinary(9 / 3), result.DivideOperation(firstValue.ConvertToBinary(9), secondValue.ConvertToBinary(3), 2));
            }
            [Fact]
            public void FifteenDividedIntoThree()
            {
                var firstValue = new BinaryNumbers();
                var secondValue = new BinaryNumbers();
                var result = new BinaryNumbers();
                Assert.Equal(result.ConvertToBinary(15 / 3), result.DivideOperation(firstValue.ConvertToBinary(15), secondValue.ConvertToBinary(3), 2));
            }
            [Fact]
            public void TwentyDividedIntoTwo()
            {
                var firstValue = new BinaryNumbers();
                var secondValue = new BinaryNumbers();
                var result = new BinaryNumbers();
                Assert.Equal(result.ConvertToBinary(20 / 2), result.DivideOperation(firstValue.ConvertToBinary(20), secondValue.ConvertToBinary(2), 2));
            }
            [Fact]
            public void ThirtyThreeDividedIntoEleven()
            {
                var firstValue = new BinaryNumbers();
                var secondValue = new BinaryNumbers();
                var result = new BinaryNumbers();
                Assert.Equal(result.ConvertToBinary(33 / 11), result.DivideOperation(firstValue.ConvertToBinary(33), secondValue.ConvertToBinary(11), 2));
            }
            [Fact]
            public void ConvertIntoBaseOp()
            {
                var value = new BinaryNumbers();
                Assert.Equal(new byte[] { 1, 255 }, value.ConvertIntoBase(511, 256));
            }
            [Fact]
            public void ConvertIntoBaseOP()
            {
                var value = new BinaryNumbers();
                Assert.Equal(new byte[] { 1, 0 }, value.ConvertIntoBase(16, 16));
            }
        }
    }
}

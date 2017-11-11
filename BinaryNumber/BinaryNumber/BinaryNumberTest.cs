using System;
using System.Collections.Generic;
using Xunit;

namespace BinaryNumber
{
    public class BinaryNumberTest
    {       
        //            [Fact]
        //            public void ANDOperator()
        //            {
        //                var firstValue = new BinaryNumbers();
        //                var secondValue = new BinaryNumbers();
        //                var result = new BinaryNumbers();
        //                Assert.Equal(new byte[] { 0, 0, 1 }, result.LogicOperation(firstValue.ConvertToBinary(1), secondValue.ConvertToBinary(7), "AND"));
        //            }
                        [Fact]
                        public void AND()
                        {
                            BinaryNumber firstValue = new BinaryNumber(2);
                            BinaryNumber secondValue = new BinaryNumber(3);
                            BinaryNumber result = new BinaryNumber(2 & 3);
                            Assert.Equal(result.GetValue(), firstValue.And(secondValue));
                        }

        //            [Fact]
        //            public void OROperator()
        //            {
        //                var firstValue = new BinaryNumbers();
        //                var secondValue = new BinaryNumbers();
        //                var result = new BinaryNumbers();
        //                Assert.Equal(new byte[] { 1, 1, 1 }, result.LogicOperation(firstValue.ConvertToBinary(1), secondValue.ConvertToBinary(7), "OR"));
        //            }
                        [Fact]
                        public void OR()
                        {
                            BinaryNumber firstValue = new BinaryNumber(1);
                            BinaryNumber secondValue = new BinaryNumber(7);
                            BinaryNumber result = new BinaryNumber(1 | 7);
                            Assert.Equal(result.GetValue(), firstValue.Or(secondValue));
                        }
        //            [Fact]
        //            public void XOROperator()
        //            {
        //                var firstValue = new BinaryNumbers();
        //                var secondValue = new BinaryNumbers();
        //                var result = new BinaryNumbers();
        //                Assert.Equal(new byte[] { 1, 1, 0 }, result.LogicOperation(firstValue.ConvertToBinary(1), secondValue.ConvertToBinary(7), "XOR"));
        //            }
                        [Fact]
                        public void XOR()
                        {
                            BinaryNumber firstValue = new BinaryNumber(1);
                            BinaryNumber secondValue = new BinaryNumber(7);
                            BinaryNumber result = new BinaryNumber(1 ^ 7);
                            Assert.Equal(result.GetValue(), firstValue.Xor(secondValue));
                        }
        //            [Fact]
        //            public void ShiftRightOperator()
        //            {
        //                var value = new BinaryNumbers();
        //                var result = new BinaryNumbers();
        //                Assert.Equal(new byte[] { 0, 1, 1 }, result.ShiftOperation(value.ConvertToBinary(7), "Right"));
        //            }
        //            [Fact]
        //            public void ShiftLeftOperator()
        //            {
        //                var value = new BinaryNumbers();
        //                var result = new BinaryNumbers();
        //                Assert.Equal(new byte[] { 1, 1, 0 }, result.ShiftOperation(value.ConvertToBinary(7), "Left"));
        //            }


                        [Fact]
                        public void ShiftRightOperator()
                        {
                            BinaryNumber firstValue = new BinaryNumber(7);
                            BinaryNumber result = new BinaryNumber(7 >> 2);
                            Assert.Equal(result.GetValue(), firstValue.ShiftR(firstValue));
                        }

                        [Fact]
                        public void ShiftLeftOperator()
                        {
                            BinaryNumber firstValue = new BinaryNumber(7);
                            BinaryNumber result = new BinaryNumber(7 << 2);
                            Assert.Equal(result.GetValue(), firstValue.ShiftL(firstValue));
                        }      



        //            [Fact]
        //            public void ForPlusThree()
        //            {
        //                var firstValue = new BinaryNumbers();
        //                var secondValue = new BinaryNumbers();
        //                var result = new BinaryNumbers();
        //                Assert.Equal(new byte[] { 1, 1, 1 }, result.AddOperation(firstValue.ConvertToBinary(4), secondValue.ConvertToBinary(3), 2));
        //            }        
        //            [Fact]
        //            public void FifteenPlusFiFteen()
        //            {
        //                var firstValue = new BinaryNumbers();
        //                var secondValue = new BinaryNumbers();
        //                var result = new BinaryNumbers();
        //                Assert.Equal(new byte[] { 1, 1, 1, 1, 0 }, result.AddOperation(firstValue.ConvertToBinary(15), secondValue.ConvertToBinary(15), 2));
        //            }
        [Fact]
                        public void ForPlusThree()
                        {
                            BinaryNumber firstValue = new BinaryNumber(4);
                            BinaryNumber secondValue = new BinaryNumber(3);
                            BinaryNumber result = new BinaryNumber(4 + 3);
                            Assert.Equal(result.GetValue(), firstValue.Add(secondValue, 2));
                        }
                        [Fact]
                        public void FifteenPlusFiFteen()
                        {
                            BinaryNumber firstValue = new BinaryNumber(15);
                            BinaryNumber secondValue = new BinaryNumber(15);
                            BinaryNumber result = new BinaryNumber(15 + 15);
                            Assert.Equal(result.GetValue(), firstValue.Add(secondValue, 2));
                        }
        //            [Fact]
        //            public void SevenMinusFive()
        //            {
        //                var firstValue = new BinaryNumbers();
        //                var secondValue = new BinaryNumbers();
        //                var result = new BinaryNumbers();
        //                Assert.Equal(new byte[] { 0, 1, 0 }, result.SubtractOperation(firstValue.ConvertToBinary(7), secondValue.ConvertToBinary(5), 2));
        //            }
        //            [Fact]
        //            public void FifteenMinusFive()
        //            {
        //                var firstValue = new BinaryNumbers();
        //                var secondValue = new BinaryNumbers();
        //                var result = new BinaryNumbers();
        //                Assert.Equal(new byte[] { 1, 0, 1, 0 }, result.SubtractOperation(firstValue.ConvertToBinary(15), secondValue.ConvertToBinary(5), 2));
        //            }
        //            [Fact]
        //            public void FifteenMinusThree()
        //            {
        //                var firstValue = new BinaryNumbers();
        //                var secondValue = new BinaryNumbers();
        //                var result = new BinaryNumbers();
        //                Assert.Equal(new byte[] { 1, 1, 0, 0 }, result.SubtractOperation(firstValue.ConvertToBinary(15), secondValue.ConvertToBinary(3), 2));
        //            }
        [Fact]
                        public void SevenMinusFive()
                        {
                            BinaryNumber firstValue = new BinaryNumber(7);
                            BinaryNumber secondValue = new BinaryNumber(5);
                            BinaryNumber result = new BinaryNumber(7 - 5);
                            Assert.Equal(result.GetValue(), firstValue.Sub(secondValue, 2));
                        }
                        [Fact]
                        public void FifteenMinusFive()
                        {
                            BinaryNumber firstValue = new BinaryNumber(15);
                            BinaryNumber secondValue = new BinaryNumber(5);
                            BinaryNumber result = new BinaryNumber(15 - 5);
                            Assert.Equal(result.GetValue(), firstValue.Sub(secondValue, 2));
                        }
                        [Fact]
                        public void FifteenMinusThree()
                        {
                            BinaryNumber firstValue = new BinaryNumber(15);
                            BinaryNumber secondValue = new BinaryNumber(3);
                            BinaryNumber result = new BinaryNumber(15 - 3);
                            Assert.Equal(result.GetValue(), firstValue.Sub(secondValue, 2));
                        }

        //            [Fact]
        //            public void NotEqual()
        //            {
        //                var firstValue = new BinaryNumbers();
        //                var secondValue = new BinaryNumbers();
        //                var result = new BinaryNumbers();
        //                Assert.Equal(true, result.NotEqual(firstValue.ConvertToBinary(10), secondValue.ConvertToBinary(11)));
        //            }
                      [Fact]
                      public void IsNotEqual()
                      {
                          BinaryNumber fristValue = new BinaryNumber(2);
                          BinaryNumber secondValue = new BinaryNumber(3);
                          Assert.True(fristValue.NotEqual(secondValue));
                      }
                      [Fact]
                      public void IsNotEqualSecondTest()
                      {
                          BinaryNumber fristValue = new BinaryNumber(3);
                          BinaryNumber secondValue = new BinaryNumber(3);
                          Assert.False(fristValue.NotEqual(secondValue));
                      }
        //            [Fact]
        //            public void Equal()
        //            {
        //                var firstValue = new BinaryNumbers();
        //                var secondValue = new BinaryNumbers();
        //                var result = new BinaryNumbers();
        //                Assert.Equal(false, result.NotEqual(firstValue.ConvertToBinary(10), secondValue.ConvertToBinary(9)));
        //            }
                      [Fact]
                      public void IsEqual()
                      {
                          BinaryNumber fristValue = new BinaryNumber(2);
                          BinaryNumber secondValue = new BinaryNumber(2);
                          Assert.True(fristValue.Equal(secondValue));
                      }
                      [Fact]
                      public void IsEqualSecondTest()
                      {
                          BinaryNumber fristValue = new BinaryNumber(2);
                          BinaryNumber secondValue = new BinaryNumber(3);
                          Assert.False(fristValue.Equal(secondValue));
                      }
        //            [Fact]
        //            public void GraterThan()
        //            {
        //                var firstValue = new BinaryNumbers();
        //                var secondValue = new BinaryNumbers();
        //                var result = new BinaryNumbers();
        //                Assert.Equal(true, result.NotEqual(firstValue.ConvertToBinary(12), secondValue.ConvertToBinary(11)));
        //            }
                      [Fact]
                      public void GraterThan()
                      {
                          BinaryNumber fristValue = new BinaryNumber(12);
                          BinaryNumber secondValue = new BinaryNumber(11);
                          Assert.True(fristValue.GraterThan(secondValue));
                      }
                      [Fact]
                      public void GraterThanSecondTest()
                      {
                          BinaryNumber fristValue = new BinaryNumber(12);
                          BinaryNumber secondValue = new BinaryNumber(12);
                          Assert.False(fristValue.GraterThan(secondValue));
                      }
        //            [Fact]
        //            public void TenTimesTwenty()
        //            {
        //                var firstValue = new BinaryNumbers();
        //                var secondValue = new BinaryNumbers();
        //                var result = new BinaryNumbers();
        //                Assert.Equal(result.ConvertToBinary(10 * 20), result.MultiplyOperation(firstValue.ConvertToBinary(10), secondValue.ConvertToBinary(20), 2));
        //            }
        //            [Fact]
        //            public void FourTimesFour()
        //            {
        //                var firstValue = new BinaryNumbers();
        //                var secondValue = new BinaryNumbers();
        //                var result = new BinaryNumbers();
        //                Assert.Equal(result.ConvertToBinary(4 * 4), result.MultiplyOperation(firstValue.ConvertToBinary(4), secondValue.ConvertToBinary(4), 2));
        //            }
        //            [Fact]
        //            public void TenTimesEleven()
        //            {
        //                var firstValue = new BinaryNumbers();
        //                var secondValue = new BinaryNumbers();
        //                var result = new BinaryNumbers();
        //                Assert.Equal(result.ConvertToBinary(10 * 11), result.MultiplyOperation(firstValue.ConvertToBinary(10), secondValue.ConvertToBinary(11), 2));
        //            }
                       [Fact]
                        public void TenTimesTwenty()
                        {
                            BinaryNumber firstValue = new BinaryNumber(10);
                            BinaryNumber secondValue = new BinaryNumber(20);
                            BinaryNumber result = new BinaryNumber(20 * 10);
                            Assert.Equal(result.GetValue(), firstValue.Multiply(secondValue, 2));
                        }
                        [Fact]
                        public void FourTimesFour()
                        {
                            BinaryNumber firstValue = new BinaryNumber(4);
                            BinaryNumber secondValue = new BinaryNumber(4);
                            BinaryNumber result = new BinaryNumber(4 * 4);
                            Assert.Equal(result.GetValue(), firstValue.Multiply(secondValue, 2));
                        }
                        [Fact]
                        public void TenTimesEleven()
                        {
                            BinaryNumber firstValue = new BinaryNumber(10);
                            BinaryNumber secondValue = new BinaryNumber(11);
                            BinaryNumber result = new BinaryNumber(10 * 11);
                            Assert.Equal(result.GetValue(), firstValue.Multiply(secondValue, 2));
                        }
        //            [Fact]
        //            public void NineDividedIntoThree()
        //            {
        //                var firstValue = new BinaryNumbers();
        //                var secondValue = new BinaryNumbers();
        //                var result = new BinaryNumbers();
        //                Assert.Equal(result.ConvertToBinary(9 / 3), result.DivideOperation(firstValue.ConvertToBinary(9), secondValue.ConvertToBinary(3), 2));
        //            }
        //            [Fact]
        //            public void FifteenDividedIntoThree()
        //            {
        //                var firstValue = new BinaryNumbers();
        //                var secondValue = new BinaryNumbers();
        //                var result = new BinaryNumbers();
        //                Assert.Equal(result.ConvertToBinary(15 / 3), result.DivideOperation(firstValue.ConvertToBinary(15), secondValue.ConvertToBinary(3), 2));
        //            }
        //            [Fact]
        //            public void TwentyDividedIntoTwo()
        //            {
        //                var firstValue = new BinaryNumbers();
        //                var secondValue = new BinaryNumbers();
        //                var result = new BinaryNumbers();
        //                Assert.Equal(result.ConvertToBinary(20 / 2), result.DivideOperation(firstValue.ConvertToBinary(20), secondValue.ConvertToBinary(2), 2));
        //            }
        //            [Fact]
                        [Fact]
                        public void NineDividedIntoThree()
                        {
                            BinaryNumber firstValue = new BinaryNumber(9);
                            BinaryNumber secondValue = new BinaryNumber(3);
                            BinaryNumber result = new BinaryNumber(9 / 3);
                            Assert.Equal(result.GetValue(), firstValue.Divide(secondValue, 2));
                        }
                        [Fact]
                        public void FifteenDividedIntoThree()
                        {
                            BinaryNumber firstValue = new BinaryNumber(15);
                            BinaryNumber secondValue = new BinaryNumber(3);
                            BinaryNumber result = new BinaryNumber(15 / 3);
                            Assert.Equal(result.GetValue(), firstValue.Divide(secondValue, 2));
                        }
                        [Fact]
                        public void TwentyDividedIntoTwo()
                        {
                            BinaryNumber firstValue = new BinaryNumber(20);
                            BinaryNumber secondValue = new BinaryNumber(2);
                            BinaryNumber result = new BinaryNumber(20 / 2);
                            Assert.Equal(result.GetValue(), firstValue.Divide(secondValue, 2));
                        }      
    }
}

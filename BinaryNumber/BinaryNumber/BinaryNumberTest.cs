using System;
using System.Collections.Generic;
using Xunit;

namespace BinaryNumber
{
    public class BinaryNumberTest
    {       
       
                        [Fact]
                        public void AND()
                        {
                            BinaryNumber firstValue = new BinaryNumber(2);
                            BinaryNumber secondValue = new BinaryNumber(3);
                            BinaryNumber result = new BinaryNumber(2 & 3);
                            Assert.Equal(result.GetValue(), firstValue.And(secondValue));
                        }

       
                        [Fact]
                        public void OR()
                        {
                            BinaryNumber firstValue = new BinaryNumber(1);
                            BinaryNumber secondValue = new BinaryNumber(7);
                            BinaryNumber result = new BinaryNumber(1 | 7);
                            Assert.Equal(result.GetValue(), firstValue.Or(secondValue));
                        }
       
                        [Fact]
                        public void XOR()
                        {
                            BinaryNumber firstValue = new BinaryNumber(1);
                            BinaryNumber secondValue = new BinaryNumber(7);
                            BinaryNumber result = new BinaryNumber(1 ^ 7);
                            Assert.Equal(result.GetValue(), firstValue.Xor(secondValue));
                        }
        

                        [Fact]
                        public void ShiftRightOperator()
                        {
                            BinaryNumber firstValue = new BinaryNumber(11);
                            BinaryNumber result = new BinaryNumber(11 >> 2);
                            Assert.Equal(result.GetValue(), firstValue.ShiftR(2));
                        }

                        [Fact]
                        public void ShiftLeftOperator()
                        {
                            BinaryNumber firstValue = new BinaryNumber(7);
                            BinaryNumber result = new BinaryNumber(7 << 2);
                            Assert.Equal(result.GetValue(), firstValue.ShiftL(2));
                        }
                        [Fact]
                        public void ShiftLeftOperatorSecondTest()
                        {
                            BinaryNumber firstValue = new BinaryNumber(15);
                            BinaryNumber result = new BinaryNumber(15 << 2);
                            Assert.Equal(result.GetValue(), firstValue.ShiftL(2));
                        }



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

                        [Fact]
                        public void SevenMinusFive()
                        {
                            BinaryNumber firstValue = new BinaryNumber(7);
                            BinaryNumber secondValue = new BinaryNumber(2);
                            BinaryNumber result = new BinaryNumber(7 - 2);
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

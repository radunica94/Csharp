﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestChessTable
{
    [TestClass]
    public class ChessTable
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(204,CalculateTheNumberOfSquares(8));
        }

        double CalculateTheNumberOfSquares(int value)
        {            
            return (value * (value + 1) * (2 * value + 1)) / 6;
        }
    }
}

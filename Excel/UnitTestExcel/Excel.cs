using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestExcel
{
    [TestClass]
    public class Excel
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual("AA",ExelColumns(27));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual("A", ExelColumns(1));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual("AB", ExelColumns(28));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual("AZ", ExelColumns(52));
        }
        [TestMethod]
        public void TestMethod5()
        {
            Assert.AreEqual("BH", ExelColumns(60));
        }
        [TestMethod]
        public void TestMethod6()
        {
            Assert.AreEqual("AAA", ExelColumns(703));
        }

        string ExelColumns(int columnID)
        {
            int id = columnID;
            string columnLetter = string.Empty;
            int mod = 0;

            while (id > 0)
            {
                mod = (id - 1) % 26;
                columnLetter = (char)(65 + mod) + columnLetter;
                id = (int)((id - mod) / 26);
            }


            return columnLetter;
        }
    }
}

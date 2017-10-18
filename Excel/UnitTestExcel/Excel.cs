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
            Assert.AreEqual(27,ExelColumns("AA"));
        }

        int ExelColumns(string columnName)
        {
            return 0;
        }
    }
}

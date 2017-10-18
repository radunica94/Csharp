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

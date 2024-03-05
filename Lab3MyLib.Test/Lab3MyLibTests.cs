using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lab3MyLib.Test
{
    [TestClass]
    public class Lab3MyLibTests
    {
        [TestMethod]
       public void IsNumericEnter_12345_Returntrue()
        {
            Assert.IsTrue(CheckPassword.IsNumeric("12345"));
        }
    }
}

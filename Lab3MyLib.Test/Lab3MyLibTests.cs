using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lab3MyLib.Test
{
    [TestClass]
    public class Lab3MyLibTests
    {
        [TestMethod]
        public void IsNumericEnter_12345_True()
        {
            Assert.IsTrue(CheckPassword.IsNumeric("12345"));
        }

        [TestMethod]
        public void IsNumericEnter_12345f_False()
        {
            Assert.IsFalse(CheckPassword.IsNumeric("12345f"));
        }

        [TestMethod]
        public void IsUppperEnter_ABCDE_True()
        {
            Assert.IsTrue(CheckPassword.IsUppper("ABCDE"));
        }
        [TestMethod]
        public void IsUppperEnter_ABcDE_False()
        {
            Assert.IsFalse(CheckPassword.IsUppper("ABcDE"));
        }

        [TestMethod]
        public void IsLowerEnter_abcde1_True()
        {
            Assert.IsTrue(CheckPassword.IsLower("abcde1"));
        }

        [TestMethod]
        public void IsLowerEnter_abCde_False()
        {
            Assert.IsFalse(CheckPassword.IsLower("abCde"));
        }

        [TestMethod]
        public void HasDigitEnter_abcde4_True()
        {
            Assert.IsTrue(CheckPassword.HasDigit("abcde4"));
        }

        [TestMethod]
        public void HasDigitEnter_abcde_False()
        {
            Assert.IsFalse(CheckPassword.HasDigit("abcde"));
        }

        [TestMethod]
        public void PasswordLevel_Enter_abcde_Return0()
        {
            int expected = 0;
            int actual = CheckPassword.PasswordLevel("abcde");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PasswordLevel_Enter_abcdef_Return1()
        {
            int expected = 1;
            int actual = CheckPassword.PasswordLevel("abcdef");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PasswordLevel_Enter_ABCDEF_Return1()
        {
            int expected = 1;
            int actual = CheckPassword.PasswordLevel("ABCDEF");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PasswordLevel_123456_Return1()
        {
            int expected = 1;
            int actual = CheckPassword.PasswordLevel("123456");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PasswordLevel_ABCDEf_Return2()
        {
            int expected = 2;
            int actual = CheckPassword.PasswordLevel("ABCDEf");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PasswordLevel_ABCDE1_Return3()
        {
            int expected = 3;
            int actual = CheckPassword.PasswordLevel("ABCDE1");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PasswordLevel_abcde1_Return2()
        {
            int expected = 2;
            int actual = CheckPassword.PasswordLevel("abcde1");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PasswordLevel_Abcde1_Return3()
        {
            int expected = 3;
            int actual = CheckPassword.PasswordLevel("Abcde1");
            Assert.AreEqual(expected, actual);
        }
    }
}

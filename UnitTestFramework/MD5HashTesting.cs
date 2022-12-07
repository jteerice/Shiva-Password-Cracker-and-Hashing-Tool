using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestFramework
{
    [TestClass]
    public class MD5HashTesting
    {
        [TestMethod]
        public void hash_String1()
        {
            string clearText = "phrase123456";
            string solution = "6596088e10363a7093d725e76fe705f8";
            MD5Hash md5Test = new MD5Hash(clearText);

            string cipherText = md5Test.hash();

            Assert.AreEqual(cipherText, solution);

        }
    }
}

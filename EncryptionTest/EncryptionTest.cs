using System;
using Caesar_Cipher_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncryptionTest
{
    [TestClass]
    public class EncryptionTest
    {
        [TestMethod]
        public void EncryptionTests()
        {
            int shift = 1;
            string text = "абв";
            string expected = "бвг";

            Encryption e = new Encryption();
            string word = e.EncyptWithInset(text, shift);

            word.Equals(expected);
        }
    }
}

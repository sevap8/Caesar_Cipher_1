using System;
using Caesar_Cipher_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncryptionTest
{
    [TestClass]
    public class DecryptionTest
    {
        [TestMethod]
        public void DecryptionTests()
        {
            int shift = 1;
            string text = "бвг";
            string expected = "абв";

            Decryption decryption = new Decryption();
            string word = decryption.DecryptWithIset(text, shift);

            word.Equals(expected);
        }
    }
}

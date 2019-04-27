using System;
using System.Collections.Generic;
using Caesar_Cipher_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EncryptionTest
{
    [TestClass]
    public class WordSearchTest
    {
        [TestMethod]
        public void UnloadTextTest()
        {
            string  way = "C:\\io\\123.txt";           

            WordSearch  wordSearch = new WordSearch();
            string text = wordSearch.UnloadText(way);

            text.Equals(text);
        }

        [TestMethod]
        public void SearchTest()
        {
            string dictionary = "some";
            List<string> wdList = new List<string>();
            WordSearch wordSearch = new WordSearch();
           int s = wordSearch.Search(dictionary, wdList);

            s.Equals(0);
            
        }
    }
}

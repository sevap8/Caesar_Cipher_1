using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Caesar_Cipher_1
{
    public class Decryption
    {
        public string DecryptWithIset(String text, int shift)
        {

            string alfphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            string wordLow = text.ToLower();

            char[] sort = new char[text.Length];

            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < alfphabet.Length; j++)
                {
                    if (wordLow[i].Equals(alfphabet[j])) // в случае совпадения создаем темп, где храню номер буквы со сдвигом
                    {
                        try
                        {
                            int a = alfphabet.IndexOf(alfphabet[j]) - shift;

                            if (a < 0)
                            {
                                a = a + 33;
                                sort[i] = alfphabet[a];
                            }
                            else
                            {
                                sort[i] = alfphabet[j - shift];
                            }
                        }
                        catch (System.IndexOutOfRangeException)
                        {
                            MessageBox.Show("Error...\n You went beyond the array!");
                        }
                    }
                    else if (wordLow[i].Equals('!') || wordLow[i].Equals(' ') || wordLow[i].Equals(',') || wordLow[i].Equals('.') ||
                        wordLow[i].Equals('#') || wordLow[i].Equals('c'))
                    {
                        sort[i] = wordLow[i];
                    }
                }
            }

            String word = new String(sort);
            return word;



        }

         public List<string> DecryptWord(String word)
         {

             List<string> wordList = new List<string>();

             string alfphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

            int shift = 0;

            for (int p = 0; p<alfphabet.Length; p++)
            {

                string txt = DecryptWithIset(word, shift);
             
                wordList.Add(txt);
                            
                shift++;
            }

            return wordList;
         }
    }
}

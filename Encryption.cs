using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Caesar_Cipher_1
{
   public class Encryption
    {
        public string EncyptWithInset(String text, int shift)
        {
            string alfphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";//работаю с русским алфавитом
            
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
                            int a = alfphabet.IndexOf(alfphabet[j]) + shift;

                            if (a >= alfphabet.Length)
                            {
                                a = a - 33;
                                sort[i] = alfphabet[a];
                            }
                            else
                            {
                                sort[i] = alfphabet[j + shift];
                            }
                        }
                        catch (System.IndexOutOfRangeException)
                        {
                            MessageBox.Show("Error...\n You went beyond the array!");
                        }

                    }
                    else if (wordLow[i].Equals('!')|| wordLow[i].Equals(' '))
                    {
                        sort[i] = wordLow[i];
                        
                    }
                }
            }
            String word = new String(sort);
            return word;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Caesar_Cipher_1
{
  

    public class WordSearch
    {
        public int s;
       
        public string UnloadText(string way)
        {
            try
            {
                FileStream stream = new FileStream(way, FileMode.Open);
                StreamReader reader = new StreamReader(stream);
                string word = reader.ReadToEnd();
                stream.Close();
                return word;
            }
            catch (System.IO.DirectoryNotFoundException)
            {
                MessageBox.Show("Упс!\n Проблема в файле или словаре, нужно прописать путь к ним в методе DecrText_Click в класе MainWindow!!!");
                throw;
            }          
        }

        public int Search(string dictionary, List<string> wordList)
        {
           
            for (int i = 0; i < wordList.Count; i++)
            {                                            
                if (dictionary.Contains(wordList[i]))
                {
                    s = i;                  
                }               
            }
            return s;
        }
    }
}

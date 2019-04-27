using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caesar_Cipher_1
{
    class SaveText
    {
        public void Сreate(string way, string text)
        {
            System.IO.File.AppendAllText(way, text);
            
        }
    }
}

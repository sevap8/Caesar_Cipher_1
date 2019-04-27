using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Caesar_Cipher_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Form1.Items.Clear();
                Encryption encryption = new Encryption();
                var text = TextBox.Text;
                var shift = Convert.ToInt32(ShiftBox.Text);
                string word = encryption.EncyptWithInset(text, shift);

                Form1.Items.Add(word);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Error...\n You wrote something wrong!");                
            }                                 
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Form1.Items.Clear();
                Decryption decryption = new Decryption();
                var text = TextBox.Text;
                var shift = Convert.ToInt32(ShiftBox.Text);
                string word = decryption.DecryptWithIset(text, shift);

                Form1.Items.Add(word);
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Error...\n You wrote something wrong!");
            }
        }

        private void DecrText_Click(object sender, RoutedEventArgs e)
        {
            Form1.Items.Clear();

            WordSearch wordSearch = new WordSearch();

            string dictionary = "C:\\io\\dictionary.txt";
            dictionary = wordSearch.UnloadText(dictionary);
            
            string text = "C:\\io\\Result.txt";
            text = wordSearch.UnloadText(text);

            string[] textSplit = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Decryption decryption = new Decryption();
            Encryption encryption = new Encryption();

            List<string> wordList = decryption.DecryptWord(textSplit[3]);
            int shift = wordSearch.Search(dictionary, wordList);

            string decrypText = decryption.DecryptWithIset(text, shift);
            Form1.Items.Add(decrypText);

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Decryption decryption = new Decryption();
            WordSearch wordSearch = new WordSearch();
            SaveText saveText = new SaveText();
            string way = positionBox.Text;
            string text = "C:\\io\\Result.txt";
            text = wordSearch.UnloadText(text);
            text = decryption.DecryptWithIset(text, 2);
            saveText.Сreate(way, text);
            MessageBox.Show("Запись создана! ");
        }
    }
}

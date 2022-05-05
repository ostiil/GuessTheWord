using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessTheWord
{
    public partial class Home : Form
    {
        public string letter;
        
        public Home()
        {
            InitializeComponent();
        }

        private void правилаИгрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RulesOfTheGame rules = new RulesOfTheGame();
            rules.ShowDialog();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            again:
            string word = textBox1.Text.ToLower();
            string[] dictionary = File.ReadAllLines(@"dictionary.txt");
            bool dict = dictionary.Contains(word);
            if (dict == false)
            {
                DialogResult result = MessageBox.Show("Такого слова нет в словаре. Добавить слово в словарь?", "Сообщение",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    StreamWriter streamWriter = new StreamWriter(@"dictionary.txt", true);
                    streamWriter.WriteLine($"{word}");
                    streamWriter.Close(); //записывается
                    goto again;
                }

            }
            bool contains = word.Contains(letter);
            if (contains)
            {
                label3.Text += letter;
                label3.Visible = true;
                CheckButton.Enabled = false;

            }
            else
            {
                label3.Text = "В веденном слове нет загаданной буквы. Попробуйте еще раз.";
                label3.Visible = true;

            }
        }


        private void groupBox1_Enter(object sender, EventArgs e) //1 раз выводит букву из противоположного алфавита, потом выбирает букву нормально
        {
            if (RussianradioButton.Checked)
            {
                string[] alphabet = File.ReadAllLines(@"RussianAlphabet.txt");
                Random random = new Random();
                var index = random.Next(0, alphabet.Length);
                for (int i = 0; i < alphabet.Length; i++)
                {
                    letter = alphabet[index];
                }
            }
            else if (EnglishradioButton.Checked)
            {
                string[] alphabet = File.ReadAllLines(@"EnglishAlphabet.txt");
                Random random = new Random();
                var index = random.Next(0, alphabet.Length);
                for (int i = 0; i < alphabet.Length; i++)
                {
                    letter = alphabet[index];
                }
            }
            textBox1.Enabled = true;
        }

        private void LookWordButton_Click(object sender, EventArgs e)
        {
            label3.Text = $"Вы сдались. Загаданная буква: {letter}";
            label3.Visible = true;
            textBox1.Enabled = false;
            CheckButton.Enabled = false;
        }
    }
}

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
        public string letter; public bool contains;
        public int  min = 0; public int  sec = 30;
        
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
            try
            {
                contains = word.Contains(letter);
            }
            catch (Exception ex)
            {
            }
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
                else if(result == DialogResult.No) {
                    label3.Text = "Этого слова нет в словаре";
                    label3.Visible = true;
                    dict = false;
                };
            }
            
            if (dict)
            {
                if (contains)
                {
                    Clean();
                    MessageBox.Show(
                    $"Вы угадали! Загаданная буква: {letter}");

                    label3.Text = $"Чтобы начать игру с начала, выберите алфавит.";
                    label3.Visible = true;
                    minLabel.Text = "0";
                    secLabel.Text = "30";
                }
                else
                {
                    label3.Text = "В веденном слове нет загаданной буквы. Попробуйте еще раз.";
                    label3.Visible = true;
                }
            }
        }

        private void LookWordButton_Click(object sender, EventArgs e)
        {
            label3.Text = $"Вы сдались. Загаданная буква: {letter}. Чтобы начать игру с начала, выберите алфавит.";
            label3.Visible = true;
            Clean();
            min = 0; sec = 30;
        }

        private void Clean()
        {
            CheckButton.Enabled = false;
            LookWordButton.Enabled =false;
            textBox1.Text = "";
            textBox1.Enabled=false;
            timer1.Stop();
        }

        private void русскийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] alphabet = File.ReadAllLines(@"RussianAlphabet.txt");
            Random random = new Random();
            var index = random.Next(0, alphabet.Length);
            for (int i = 0; i < alphabet.Length; i++)
            {
                letter = alphabet[index];
            }
            textBox1.Enabled = true;
            CheckButton.Enabled = true;
            LookWordButton.Enabled = true;
            label3.Text = "";
            label3.Visible = true;
            timer1.Start();
        }

        private void английскиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] alphabet = File.ReadAllLines(@"EnglishAlphabet.txt");
            Random random = new Random();
            var index = random.Next(0, alphabet.Length);
            for (int i = 0; i < alphabet.Length; i++)
            {
                letter = alphabet[index];
            }
            textBox1.Enabled = true;
            CheckButton.Enabled = true;
            LookWordButton.Enabled = true;
            label3.Text = "";
            label3.Visible = true ;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            minLabel.Text = min.ToString();
            secLabel.Text = sec.ToString();
            sec -= 1;
            if (sec < 0)
            {
                min -= 1;
                sec = 59;
            }

            if (min ==0 && sec == 0)
            {
                Clean();
                secLabel.Text = sec.ToString();
                minLabel.Text = min.ToString();
                label3.Visible = true;
                label3.Text = $"Время вышло. Вы проиграли. Загаданная буква: {letter}. Чтобы начать игру сначала выберите алфавит";
                sec = 30; min = 0;
            }
        }

        private void минутаToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            min = 1; sec = 30;
            timer1_Tick(sender, e);
        }

        private void сек59ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            min = 0; sec = 59;
            timer1_Tick((object)sender, e);
        }

        private void секундToolStripMenuItem_Click(object sender, EventArgs e)
        {
            min = 2; sec = 0;
            timer1_Tick(sender, e);
        }
    }
}

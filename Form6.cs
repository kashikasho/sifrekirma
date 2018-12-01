using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Replace("a", "1");
            textBox1.Text = textBox1.Text.Replace("b", "2");
            textBox1.Text = textBox1.Text.Replace("c", "3");
            textBox1.Text = textBox1.Text.Replace("ç", "‼");
            textBox1.Text = textBox1.Text.Replace("d", "4");
            textBox1.Text = textBox1.Text.Replace("e", "5");
            textBox1.Text = textBox1.Text.Replace("f", "6");
            textBox1.Text = textBox1.Text.Replace("g", "7");
            textBox1.Text = textBox1.Text.Replace("ğ", "8");
            textBox1.Text = textBox1.Text.Replace("h", "9");
            textBox1.Text = textBox1.Text.Replace("ı", "0");
            textBox1.Text = textBox1.Text.Replace("i", "*");
            textBox1.Text = textBox1.Text.Replace("j", "-");
            textBox1.Text = textBox1.Text.Replace("k", "☺");
            textBox1.Text = textBox1.Text.Replace("l", "☻");
            textBox1.Text = textBox1.Text.Replace("m", "♥");
            textBox1.Text = textBox1.Text.Replace("n", "♦");
            textBox1.Text = textBox1.Text.Replace("o", "♠");
            textBox1.Text = textBox1.Text.Replace("ö", "•");
            textBox1.Text = textBox1.Text.Replace("p", "◘");
            textBox1.Text = textBox1.Text.Replace("r", "○");
            textBox1.Text = textBox1.Text.Replace("s", "◙");
            textBox1.Text = textBox1.Text.Replace("ş", "♂");
            textBox1.Text = textBox1.Text.Replace("t", "♀");
            textBox1.Text = textBox1.Text.Replace("u", "♪");
            textBox1.Text = textBox1.Text.Replace("ü", "♫");
            textBox1.Text = textBox1.Text.Replace("v", "↕");
            textBox1.Text = textBox1.Text.Replace("y", "►");
            textBox1.Text = textBox1.Text.Replace("z", "◄");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.Replace("1", "d");
            textBox2.Text = textBox2.Text.Replace("2", "e");
            textBox2.Text = textBox2.Text.Replace("3", "f");
            textBox2.Text = textBox2.Text.Replace("‼", "g");
            textBox2.Text = textBox2.Text.Replace("4", "ğ");
            textBox2.Text = textBox2.Text.Replace("5", "h");
            textBox2.Text = textBox2.Text.Replace("6", "ı");
            textBox2.Text = textBox2.Text.Replace("7", "i");
            textBox2.Text = textBox2.Text.Replace("8", "j");
            textBox2.Text = textBox2.Text.Replace("9", "k");
            textBox2.Text = textBox2.Text.Replace("0", "l");
            textBox2.Text = textBox2.Text.Replace("*", "m");
            textBox2.Text = textBox2.Text.Replace("-", "n");
            textBox2.Text = textBox2.Text.Replace("☺", "o");
            textBox2.Text = textBox2.Text.Replace("☻", "ö");
            textBox2.Text = textBox2.Text.Replace("♥", "p");
            textBox2.Text = textBox2.Text.Replace("♦", "r");
            textBox2.Text = textBox2.Text.Replace("♠", "s");
            textBox2.Text = textBox2.Text.Replace("•", "ş");
            textBox2.Text = textBox2.Text.Replace("◘", "t");
            textBox2.Text = textBox2.Text.Replace("○", "u");
            textBox2.Text = textBox2.Text.Replace("◙", "ü");
            textBox2.Text = textBox2.Text.Replace("♂", "v");
            textBox2.Text = textBox2.Text.Replace("♀", "y");
            textBox2.Text = textBox2.Text.Replace("♪", "z");
            textBox2.Text = textBox2.Text.Replace("♫", "a");
            textBox2.Text = textBox2.Text.Replace("↕", "b");
            textBox2.Text = textBox2.Text.Replace("►", "c");
            textBox2.Text = textBox2.Text.Replace("◄", "ç");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            this.Hide();
            frm2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox2.Text.Replace("1", "ü");
            textBox2.Text = textBox2.Text.Replace("2", "v");
            textBox2.Text = textBox2.Text.Replace("3", "y");
            textBox2.Text = textBox2.Text.Replace("‼", "z");
            textBox2.Text = textBox2.Text.Replace("4", "a");
            textBox2.Text = textBox2.Text.Replace("5", "b");
            textBox2.Text = textBox2.Text.Replace("6", "c");
            textBox2.Text = textBox2.Text.Replace("7", "ç");
            textBox2.Text = textBox2.Text.Replace("8", "d");
            textBox2.Text = textBox2.Text.Replace("9", "e");
            textBox2.Text = textBox2.Text.Replace("0", "f");
            textBox2.Text = textBox2.Text.Replace("*", "g");
            textBox2.Text = textBox2.Text.Replace("-", "ğ");
            textBox2.Text = textBox2.Text.Replace("☺", "h");
            textBox2.Text = textBox2.Text.Replace("☻", "ı");
            textBox2.Text = textBox2.Text.Replace("♥", "i");
            textBox2.Text = textBox2.Text.Replace("♦", "j");
            textBox2.Text = textBox2.Text.Replace("♠", "k");
            textBox2.Text = textBox2.Text.Replace("•", "l");
            textBox2.Text = textBox2.Text.Replace("◘", "m");
            textBox2.Text = textBox2.Text.Replace("○", "n");
            textBox2.Text = textBox2.Text.Replace("◙", "o");
            textBox2.Text = textBox2.Text.Replace("♂", "ö");
            textBox2.Text = textBox2.Text.Replace("♀", "p");
            textBox2.Text = textBox2.Text.Replace("♪", "r");
            textBox2.Text = textBox2.Text.Replace("♫", "s");
            textBox2.Text = textBox2.Text.Replace("↕", "ş");
            textBox2.Text = textBox2.Text.Replace("►", "t");
            textBox2.Text = textBox2.Text.Replace("◄", "u");
        }
    }
}
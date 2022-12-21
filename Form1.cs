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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Calculator calculate = new Calculator(); //создание переменной класса для вычислений

        private void Form1_Load(object sender, EventArgs e) //событие загрузки формы
        {
            calculate.formload(textBoxAsk, labelPlusMinus);
        }
       
        private void buttonAsk_Click(object sender, EventArgs e) //кнопка вычислений
        {
            calculate.Ask(textBoxAsk, labelPlusMinus);
        }

        private void button1_Click(object sender, EventArgs e) //кнопка цифры 1
        {
            calculate.Number("1", textBoxAsk, labelPlusMinus);
        }
        private void button2_Click(object sender, EventArgs e) //кнопка цифры 2
        {
            calculate.Number("2", textBoxAsk, labelPlusMinus);
        }
        private void button3_Click(object sender, EventArgs e) //кнопка цифры 3
        {
            calculate.Number("3", textBoxAsk, labelPlusMinus);
        }
        private void button4_Click(object sender, EventArgs e) //кнопка цифры 4
        {
            calculate.Number("4", textBoxAsk, labelPlusMinus);
        }
        private void button5_Click(object sender, EventArgs e) //кнопка цифры 5
        {
            calculate.Number("5", textBoxAsk, labelPlusMinus);
        }
        private void button6_Click(object sender, EventArgs e) //кнопка цифры 6
        {
            calculate.Number("6", textBoxAsk, labelPlusMinus);
        }
        private void button7_Click(object sender, EventArgs e) //кнопка цифры 7
        {
            calculate.Number("7", textBoxAsk, labelPlusMinus);
        }
        private void button8_Click(object sender, EventArgs e) //кнопка цифры 8
        {
            calculate.Number("8", textBoxAsk, labelPlusMinus);
        }
        private void button9_Click(object sender, EventArgs e) //кнопка цифры 9
        {
            calculate.Number("9", textBoxAsk, labelPlusMinus);
        }
        private void button0_Click(object sender, EventArgs e) //кнопка цифры 0
        {
            calculate.Number("0", textBoxAsk, labelPlusMinus);
        }

        private void buttonClear_Click(object sender, EventArgs e) //кнопка отчистки
        {
            calculate.formload(textBoxAsk, labelPlusMinus);
        }

        private void buttonPlus_Click(object sender, EventArgs e) //кнопка сложения
        {
            calculate.Sign("+", textBoxAsk, labelPlusMinus);
        }

        private void buttonMinus_Click(object sender, EventArgs e) //кнопка разности
        {
            calculate.Sign("-", textBoxAsk, labelPlusMinus);
        }

        private void buttonDivide_Click(object sender, EventArgs e) //кнопка частного
        {
            calculate.Sign("/", textBoxAsk, labelPlusMinus);
        }

        private void buttonMultiply_Click(object sender, EventArgs e) //кнопка произведения
        {
            calculate.Sign("*", textBoxAsk, labelPlusMinus);
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e) //кнопка смены знака перед числом
        {
            calculate.PlusMinus(labelPlusMinus, textBoxAsk);
        }
    }
}

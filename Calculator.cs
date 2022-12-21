using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public class Calculator
    {

        double a, b; //переменные для проведения расчетов
        string sign; //выбранный знак *,-,=,/
        bool znak; //переменная для проверки положительное или отрицательное значение
        bool checksign; //переменная для проверки первого определения знака
        bool calculations; //переменная для проверки на провелись ли расчеты
        bool variable1; //переменная для проверки введения 1-ого числа
        bool variable2; //переменная для проверки введения 2-ого числа

        public void formload(TextBox textBoxAsk, Label labe) //метод установки параметров при запуске и отчистке калькулятора
        {
            znak = true; //число положительное по стандарту
            checksign = false; //знак не был выбран
            calculations = false; //вычисления не проводились
            variable1 = false; //1-ое число не вводилось
            variable2 = false; //2-ое число не вводилось
            textBoxAsk.Text = "0"; //при запуске и отчистке в поле появляется 0
            labe.Text = ""; //показатель положительность или отрицательности числа, по стандарту +
        }

        public void Sign(string sign2, TextBox textBoxAsk, Label labe) //метод выбора знака
        {
            if (!variable2) 
            {
                sign = sign2;
            }
            if (!calculations) 
            {
                a = Num(textBoxAsk);               
                if (!znak) 
                {
                    a *= -1;
                }
                variable1 = true;
                znak = true;
                checksign = true;
                calculations = true;
            }
            if (variable2) 
            {
                Ask(textBoxAsk, labe);
                a = Num(textBoxAsk);
                if (!znak)
                {
                    a *= -1;
                }
                znak = true;
                sign = sign2;
                variable1 = true;
                checksign = true;
                calculations = true;
            }           
        }

        public void Number(string number, TextBox textBoxAsk, Label plusminus) //метод ввода цифр в поле (не более 9)
        {
            if (variable1)
            {
                variable2 = true;
                variable1 = false;
            }
            if (textBoxAsk.Text == "0")
            {
                textBoxAsk.Text = "";
            }
            if (textBoxAsk.TextLength < 9 || checksign)
            {
                if (checksign)
                {
                    textBoxAsk.Clear();
                    plusminus.Text = "";
                    checksign = false;
                }
                textBoxAsk.Text += number;
            }           
        }

        public void Ask(TextBox textBoxAsk, Label labe) //метод для вызова вычислений
        {
            if (calculations && variable2)
            {
                Calculate(textBoxAsk, labe); 
            }           
        }

        public double Num(TextBox textBoxAsk) //метод конвертации string в double
        {
            return Convert.ToDouble(textBoxAsk.Text);
        }
        public void Askmet(TextBox textBoxAsk) => textBoxAsk.Text = Math.Round(b, 1).ToString(); //метод для вывода результата вычислений 

        public void Calculate(TextBox textBoxAsk, Label plusminus) //метод вычислений
        {
            double num = Num(textBoxAsk);
            if (!znak)
            {
                num *= -1;
            }
            znak = true;
            switch (sign)
            {
                case "+":
                    b = a + num;
                    Askmet(textBoxAsk);
                    break;
                case "-":
                    b = a - num;
                    Askmet(textBoxAsk);
                    break;
                case "*":
                    b = a * num;
                    Askmet(textBoxAsk);
                    break;
                case "/":
                    b = a / num;
                    Askmet(textBoxAsk);
                    if (num == 0)
                    {
                        textBoxAsk.Text = "not / 0"; //нельзя делить на 0
                    }
                    break;
                default:
                    break;
            }
            b = Math.Round(b, 1);
            if (b <= 0)
            {
                plusminus.Text = "-";
                znak = false;
            }
            if (b >= 0 || textBoxAsk.Text == "0")
            {
                plusminus.Text = "";
            }
            string btest = b.ToString();
            if (btest.Length > 9)
            {
                textBoxAsk.Text = "EXCEEDED"; //нарушение максимальной разрядности числа (9 разрядов) 
            }
            textBoxAsk.Text = textBoxAsk.Text.Replace("-", "");
            calculations = false;
            variable2 = false;
            checksign = true;
        }

        public void PlusMinus(Label labelplusminus, TextBox textBoxAsk) //Метод для установки отрицательности, положительности числа
        {
            if (znak)
            {
                labelplusminus.Text = "-";
                znak = false;
            }
            else if (!znak)
            {
                labelplusminus.Text = "";
                znak = true;
            }           
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        string Znak = null;
        bool Начало_Ввода = true;
        Double Число1, Число2;
     

        private void button12_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            this.Size = new Size(500,489);
            this.button1.Click += new System.EventHandler(this.ЦИФРА);
            this.button2.Click += new System.EventHandler(this.ЦИФРА);
            this.button3.Click += new System.EventHandler(this.ЦИФРА);
            this.button4.Click += new System.EventHandler(this.ЦИФРА);
            this.button5.Click += new System.EventHandler(this.ЦИФРА);
            this.button6.Click += new System.EventHandler(this.ЦИФРА);
            this.button7.Click += new System.EventHandler(this.ЦИФРА);
            this.button8.Click += new System.EventHandler(this.ЦИФРА);
            this.button9.Click += new System.EventHandler(this.ЦИФРА);
            this.button10.Click += new System.EventHandler(this.ЦИФРА);
            this.button12.Click += new System.EventHandler(this.ОПЕРАЦИЯ);
            this.button13.Click += new System.EventHandler(this.ОПЕРАЦИЯ);
            this.button14.Click += new System.EventHandler(this.ОПЕРАЦИЯ);
            this.button15.Click += new System.EventHandler(this.ОПЕРАЦИЯ);
            this.button11.Click += new System.EventHandler(this.РАВНО);
            this.button16.Click += new System.EventHandler(this.Очистить);
            this.buttonStepen.Click += new System.EventHandler(this.Stepen);
            this.buttonZapyataya.Click += new System.EventHandler(this.ЦИФРА);
            this.buttonKoren.Click += new System.EventHandler(this.КвадратныйКорень);
            this.buttonObratnoeZnachenie.Click += new System.EventHandler(this.ОбратноеЗначение);
            this.buttonKvadratChisla.Click += new System.EventHandler(this.ОпределениеКвадратаЧисла);
        }
        private void ЦИФРА(object sender, EventArgs e)
        {
            Button Кнопка = (Button)sender;
            string Digit = Кнопка.Text;
            if (Начало_Ввода == true)
            {
                textBox1.Text = Digit;
                Начало_Ввода = false;
                return;
            }
            if (Начало_Ввода == false)
            {
                textBox1.Text = textBox1.Text + Digit;
            }
        }
        private void ОПЕРАЦИЯ(object sender, EventArgs e)
        {
            try
            {
                Число1 = Double.Parse(textBox1.Text);
                Button Кнопка = (Button)sender;
                Znak = Кнопка.Text;
                Начало_Ввода = true;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка:" +e.ToString());
                Начало_Ввода = true;
            }
        }
        private void РАВНО(object sender,EventArgs e)
        {
            try
            {
                double Результат = 0;
                Число2 = Double.Parse(textBox1.Text);
                if (Znak == "+")
                    Результат = Число1 + Число2;
                if (Znak == "-")
                    Результат = Число1 - Число2;
                if (Znak == "*")
                    Результат = Число1 * Число2;
                if (Znak == "/")
                    Результат = Число1 / Число2;
                if (Znak == "Возведение в степень")
                {
                    
                    Результат = Math.Pow(Число1, Число2);
                    
                }



                Znak = null;
                textBox1.Text = Результат.ToString();
                Число1 = Результат;
                Начало_Ввода = true;
            }
            catch(Exception a)
            {
                MessageBox.Show("Произошло исключение:"+a.ToString());
                textBox1.Text = "0";
                Начало_Ввода = true;
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Stepen(object sender,EventArgs e)
        {
            try
            {
                
                Число1 = Convert.ToDouble(textBox1.Text);
                
                    Button Кнопка = (Button)sender;
                    Znak = Кнопка.Text;
                    Начало_Ввода = true;
                
                
            }
            catch (Exception a)
            {
                MessageBox.Show("Произошло исключение:" + a.ToString());
                textBox1.Text = "0";
                Начало_Ввода = true;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            
        }

        private void Очистить(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            Znak = null;
            Начало_Ввода = true;
        }
        private void КвадратныйКорень(object sender, EventArgs e)
        {
            try
            {
                Число1 = Convert.ToDouble(textBox1.Text);
                Znak = "Квадратный корень";
                double резульатДляКорня = Math.Sqrt(Число1);
                textBox1.Text = резульатДляКорня.ToString();
                Начало_Ввода = true;
            }
            catch (Exception a)
            {
                MessageBox.Show("Произошло исключение:" + a.ToString());
                textBox1.Text = "0";
                Начало_Ввода = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ОбратноеЗначение (object sender, EventArgs e)
        {
            try
            {
                Число1 = Convert.ToDouble(textBox1.Text);
                double результатОбратногоЗначения = 1 / Число1;
                textBox1.Text = результатОбратногоЗначения.ToString();
                Начало_Ввода = true;
            }
            catch (Exception a)
            {
                MessageBox.Show("Произошло исключение:" + a.ToString());
                textBox1.Text = "0";
                Начало_Ввода = true;
            }

        }

        private void инженерныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(659, 489);
        }

        private void простойToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new Size(500, 489);
        }

        private void buttonFactorial_Click(object sender, EventArgs e)
        {
            
                int myI;
                int answer;
                string s = textBox1.Text;
                bool CheckInt = Int32.TryParse(s, out myI);
                if (CheckInt == true)
                {
                    bool ok = Program.Factorial(myI, out answer);
                    textBox1.Text = Convert.ToString(answer);
                }
                else
                {
                    MessageBox.Show("Вы вели не инт для расчета фактороиала!");
                }
            
            
        }

        private void переходДляКвадратногоУравненияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newForm2 = new Form2();
            newForm2.Show();
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            try
            {

                double ЧислоСминусом;
                    ЧислоСминусом = Convert.ToDouble(textBox1.Text);
                    
                    ЧислоСминусом = (-1) * ЧислоСминусом;
                    textBox1.Text = ЧислоСминусом.ToString();
                
               
            }
            catch (Exception a)
            {
                MessageBox.Show(a.ToString());
            }
        }

        private void buttonKubKoren_Click(object sender, EventArgs e)
        {
           
            double a= Convert.ToDouble(textBox1.Text);
            if (a >= 0)
            {
                double kubkor = Math.Pow(a, 1.0 / 3.0);
                textBox1.Text = Convert.ToString(kubkor);
            }
            else if (a < 0)
            {
                a = a * (-1);
                double kubkor = -1*Math.Pow(a, 1.0 / 3.0);
                textBox1.Text = Convert.ToString(kubkor);
            }
        }

        private void buttonStepen_Click(object sender, EventArgs e)
        {

        }

        private void ОпределениеКвадратаЧисла(object sender,EventArgs e)
        {
            try
            {
                Число1 = Convert.ToDouble(textBox1.Text);
                double результатКвадрата = Число1 * Число1;
                textBox1.Text = результатКвадрата.ToString();
                Начало_Ввода = true;
            }
            catch (Exception a)
            {
                MessageBox.Show("Произошло исключение:" + a.ToString());
                textBox1.Text = "0";
                Начало_Ввода = true;
            }
        }
    }
}

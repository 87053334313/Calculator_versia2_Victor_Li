using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            A_textBox.Text = "";
            B_TextBox.Text = "";
            C_TB.Text = "";
            RichTextBox.Text = "";
        }

        private void MyButtonKvur_Click(object sender, EventArgs e)
        {
            try
            {
                double a = Convert.ToDouble(A_textBox.Text);
                double b = Convert.ToDouble(B_TextBox.Text);
                double c = Convert.ToDouble(C_TB.Text);
                string otvet = Program.KvUravnenie(a, b, c);
                RichTextBox.Text = otvet;
            }
            catch (System.FormatException a)
            {
                MessageBox.Show("произошла ошибка связананя с некоректным водом данных \n проверь вводимые поля");
            }
        }
    }
}

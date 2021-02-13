using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        
            public static string KvUravnenie(double a, double b, double c)
            {
                double D = b * b - 4 * a * c;
                if (D > 0)
                {
                    string strX = "имеется два корня уравнения, т.к. Дискреминант больше нуля  ";
                    double x1 = ((-b + (Math.Sqrt(D))) / (2 * a));
                    double x2 = ((-b - (Math.Sqrt(D))) / (2 * a));
                    string Sx1 = "Первый корень x1=" + x1.ToString() + "   ";
                    string Sx2 = "Второй корень x2=" + x2.ToString() + "   ";
                    string otvet = strX + Sx1 + Sx2;
                    return otvet;
                }
                else if (D == 0)
                {
                    string strx = "имеется олин корень уравнения, т.к. Дискреминано равен нулю";
                    double x = (-b) / (2 * a);
                    string sx = "Корень уравненя=" + x.ToString();
                    string otvet = strx + sx;
                    return otvet;
                }
                else
                {
                    string strX = "Нет корней, т.к. Дискрименант меньше нуля";
                    string otvet = strX;
                    return otvet;
                }
            
        }
        public static bool Factorial(int n, out int answer)
        {
            int k;
            int f;
            bool ok = true;
            if (n < 0)
                ok = false;
            try
            {
                checked
                {
                    f = 1;
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Произошло исключение я обнуляю результат для факториала");
                f = 0;
                ok = false;
            }
            answer = f;
            return ok;
        }
    }
}

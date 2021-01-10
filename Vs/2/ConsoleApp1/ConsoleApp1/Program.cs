using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите a = ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b = ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c = ");
            double c = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите начальное значение x = ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите конечное значение x = ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите шаг для x = ");
            double x3 = Convert.ToDouble(Console.ReadLine());
            for (double x = x1; x < x2; x = x + x3)
            {
                double f;
                if ((x < 3) & (b != 0))
                    f = a * Math.Pow(x, 2) - b * x + c;
                else
                    if ((x > 3) & (b == 0))
                        f = (x - a) / (x - c);
                    else
                        f = x / c;
                Console.WriteLine("f = " + Convert.ToString(f) + ", при x = " + Convert.ToString(x));
            }
            Console.ReadLine();
        }
    }
}

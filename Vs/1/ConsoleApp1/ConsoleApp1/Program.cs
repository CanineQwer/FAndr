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
            double z1 = Math.Sin(Math.PI / 2f + 3f * a) / (1f - Math.Sin(3f * a - Math.PI));
            double z2 = 1f / Math.Tan(5f / 4f * Math.PI + 3f / 2f * a);
            Console.WriteLine("z1 = " + Convert.ToString(z1));
            Console.WriteLine("z2 = " + Convert.ToString(z2));
            Console.ReadLine();
        }
    }
}

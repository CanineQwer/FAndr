using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MARSH
{
    public string start, end;
    public int num;

    public MARSH(string start, string end, int num)
    {
        this.start = start;
        this.end = end;
        this.num = num;
    }
    public override string ToString()
    {
        return "Номер маршрута: "+ Convert.ToString(num) + ", начало маршрута: " + start + ", конец маршрута: " + end + '.';
    }
}

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int kol = 8;
            MARSH[] marshs;
            marshs = new MARSH[kol];
            for (int i = 0; i < kol; i++)
            {
                Console.Write("Введите начальный пункт для " + Convert.ToString(i + 1) + " маршрута: ");
                string s = Console.ReadLine();
                Console.Write("Введите конечны пункт для " + Convert.ToString(i + 1) + " маршрута: ");
                string e = Console.ReadLine();
                Console.Write("Введите номер для " + Convert.ToString(i + 1) + " маршрута: ");
                int n = Convert.ToInt32(Console.ReadLine());
                marshs[i] = new MARSH(s, e, n);
            }
            Console.WriteLine("Спасибо, массив заполнен.");
            while (true)
            {
                Console.Write("Введите номер интересующего вас маршрута: ");
                int n = Convert.ToInt32(Console.ReadLine());
                int sea = -1;
                for (int i = 0; i < kol; i++)
                    if (marshs[i].num == n)
                    {
                        sea = i;
                        break;
                    }
                if (sea == -1)
                    Console.WriteLine("Маршрут с указанным номером не найден");
                else
                    Console.WriteLine(Convert.ToString(marshs[sea]));
            }
        }
    }
}

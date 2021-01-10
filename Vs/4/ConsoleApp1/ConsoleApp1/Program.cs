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
            const int n = 11;
            int[,] mass;
            mass = new int[n, n];
            var rand = new Random();
            Console.WriteLine("Оригинальный массив = ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    mass[i, j] = rand.Next(0, 10);
                    Console.Write(Convert.ToString(mass[i, j]) + ", ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Задание 1: поиск локальнымх минимумов");
            Console.WriteLine("Локальные минимумы:");
            int kol = 0;
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                {
                    //смотрим вверх
                    if (i > 0)
                        if (mass[i, j] >= mass[i - 1, j]) continue;
                    //смотрим вниз
                    if (i < n - 1)
                        if (mass[i, j] >= mass[i + 1, j]) continue;
                    //смотрим влево
                    if (j > 0)
                        if (mass[i, j] >= mass[i, j - 1]) continue;
                    //смотрим вправо
                    if (j < n - 1)
                        if (mass[i, j] >= mass[i, j + 1]) continue;
                    kol++;
                    Console.Write('[' + Convert.ToString(i) + ',' + Convert.ToString(j) + ']');
                }
            Console.WriteLine();
            Console.WriteLine("Их колличество: " + Convert.ToString(kol));
            Console.WriteLine("Задание 2: Найти сумму модулей элементов, расположенных выше главной диагонали");
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write(new String(' ', 3 + i * 3));
                for (int j = i + 1; j < n; j++)
                {
                    Console.Write(Convert.ToString(mass[i, j]) + ", ");
                    sum = sum + mass[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine("Их сумма: " + Convert.ToString(sum));

            Console.ReadLine();
        }
    }
}

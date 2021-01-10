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
            const int n = 10;
            int[] mass;
            mass = new int[n];
            var rand = new Random();
            Console.Write("Оригинальный массив = ");
            for (int i = 0; i < n; i++)
            {
                mass[i] = rand.Next(-9, 10);
                Console.Write(Convert.ToString(mass[i]) + ", ");
            }
            Console.WriteLine();
            Console.Write("Задание 1: минимальный по модулю элемент массива = ");
            int buf = mass[0], pos = 0;
            for (int i = 1; i < n; i++)
            {
                if (Math.Abs(buf) > Math.Abs(mass[i]))
                {
                    buf = mass[i];
                    pos = i;
                }
            }
            Console.Write(Convert.ToString(buf) + ", он стоит на " + Convert.ToString(pos + 1) + " позиции");
            Console.WriteLine();
            Console.WriteLine("Задание 2: найти сумму модулей элементов массива, расположенных после первого элемента, равного нулю.");
            pos = -1;
            for (int i = 1; i < n; i++)
            {
                if (mass[i] == 0)
                    pos = i;
            }
            if (pos == -1)
                Console.WriteLine("В массиве нет элементов равных нулю, перезапустите программу для перегенерации массива");
            else
            {
                Console.WriteLine("Позиция нулевого элемента = " + Convert.ToString(pos + 1));
                buf = 0;
                for (int i = pos + 1; i < n; i++)
                    buf = buf + mass[i];
                Console.WriteLine("Сумма элементов после него = " + Convert.ToString(buf));
            }
            Console.WriteLine("Задание 3: Преобразовать массив таким образом, чтобы в первой его половине располагались элементы, стоявшие в четных позициях, а во второй половине — элементы, стоявшие в нечетных позициях.");
            int[] mass2;
            mass2 = new int[n];
            for (int i = 0; i < n / 2 + n % 2; i++)  //Переставляем четные цифры
            {
                mass2[i] = mass[i * 2];
            }
             for (int i = 0; i < n / 2; i++)  //Переставляем нечетные цифры
            {
                mass2[n / 2 + n % 2 + i] = mass[i * 2 + 1];
            }
            mass2.CopyTo(mass, 0);
            Console.Write("Получившийся массив = ");
            for (int i = 0; i < n; i++)
                Console.Write(Convert.ToString(mass[i]) + ", ");
            Console.ReadLine();
        }
    }
}

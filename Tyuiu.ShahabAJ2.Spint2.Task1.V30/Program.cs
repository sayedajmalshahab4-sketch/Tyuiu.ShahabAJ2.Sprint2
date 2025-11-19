using System;
using Tyuiu.Shahab4.Sprint2.Task1.V30.Lib;

namespace Tyuiu.Shahab4.Sprint2.Task1.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Шахаб А. | АСОиУБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Операции сравнения и логические операции                         *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Шахаб А. | АСОиУБ-23-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций,        *");
            Console.WriteLine("* которая вернет логическую последовательность (True, False, True,       *");
            Console.WriteLine("* True, True, False), при a = 657, b = 874, c = 14, d = 654              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a = 657;
            int b = 874;
            int c = 14;
            int d = 654;

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"c = {c}");
            Console.WriteLine($"d = {d}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            bool[] result = ds.GetCompareOperations(a, b, c, d);

            Console.WriteLine("Логическая последовательность:");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"[{i}] = {result[i]}");
            }

            Console.ReadKey();
        }
    }
}
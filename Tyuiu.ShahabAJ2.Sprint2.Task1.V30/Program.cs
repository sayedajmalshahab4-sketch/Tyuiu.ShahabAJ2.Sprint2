using System;
using Tyuiu.ShahabAJ2.Sprint2.Task1.V30.Lib;

namespace Tyuiu.ShahabAJ2.Sprint2.Task1.V30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Шахаб А. Дж. | АСОиУБ-25-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Логические операции                                               *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #30                                                             *");
            Console.WriteLine("* Выполнил: Шахаб Али Джафар | АСОиУБ-25-1                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу из операций сравнений и логических операций,         *");
            Console.WriteLine("* которая вернет логическую последовательность:                           *");
            Console.WriteLine("* (True, False, True, True, True, False) при a=657, b=874, c=14, d=654    *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a = 657;
            int b = 874;
            int c = 14;
            int d = 654;

            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();
            bool[] result = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("Логическая последовательность:");
            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"result[{i}] = {result[i]}");
            }

            Console.WriteLine();
            Console.WriteLine("Полная последовательность: (" + string.Join(", ", result) + ")");

            Console.ReadKey();
        }
    }
}



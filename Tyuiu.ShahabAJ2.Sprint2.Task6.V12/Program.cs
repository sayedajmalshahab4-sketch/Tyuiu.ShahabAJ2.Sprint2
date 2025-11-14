using System;
using Tyuiu.ShahabAJ2.Sprint2.Task6.V12.Lib;

namespace Tyuiu.ShahabAJ2.Sprint2.Task6.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #2 | Выполнил: Шахаб | АСОиУБ-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Оператор switch                                                   *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Шахаб Али Джафар | АСОиУБ-25-1                                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дата некоторого дня характеризуется тремя натуральными числами: g       *");
            Console.WriteLine("* (год), m (порядковый номер месяца) и n (число). По заданным g, n и m   *");
            Console.WriteLine("* определить дату предыдущего дня. Заданный год является високосным.     *");
            Console.WriteLine("* Использовать сокращенную форму записи оператора switch.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите год (g): ");
            int g = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите месяц (m): ");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите число (n): ");
            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            string result = ds.FindDateOfPreviousDay(g, m, n);
            Console.WriteLine("Дата предыдущего дня: " + result);

            Console.ReadKey();
        }
    }
}
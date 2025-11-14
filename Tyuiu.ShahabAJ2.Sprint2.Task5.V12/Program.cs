using System;
using Tyuiu.ShahabAJ2.Sprint2.Task5.V12.Lib;

namespace Tyuiu.ShahabAJ2.Sprint2.Task5.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

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
            Console.WriteLine($"Дата предыдущего дня: {result}");

            Console.ReadKey();
        }
    }
}
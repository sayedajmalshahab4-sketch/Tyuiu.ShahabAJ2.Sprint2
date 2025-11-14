using System;
using Tyuiu.ShahabAJ2.Sprint2.Task2.V25.Lib;

namespace Tyuiu.ShahabAJ2.Sprint2.Task2.V25
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*************************");

            Console.Write("Введите X: ");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите Y: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("*************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("*************************");

            bool result = ds.CheckDotInShadedArea(x, y);

            if (result)
            {
                Console.WriteLine("Точка находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine("Точка не находится в заштрихованной области");
            }

            Console.ReadKey();
        }
    }
}
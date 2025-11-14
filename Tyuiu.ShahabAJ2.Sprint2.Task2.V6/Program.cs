using System;
using Tyuiu.ShahabAJ2.Sprint2.Task7.V25.Lib;

namespace Tyuiu.ShahabAJ2.Sprint2.Task7.V25
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            Console.Write("Введите координату X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите координату Y: ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            bool inArea = ds.CheckDotInShadedArea(x, y);

            if (inArea)
            {
                Console.WriteLine($"Точка ({x}, {y}) находится в заштрихованной области");
            }
            else
            {
                Console.WriteLine($"Точка ({x}, {y}) НЕ находится в заштрихованной области");
            }

            Console.ReadKey();
        }
    }
}

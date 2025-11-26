using System;

namespace Tyuiu.ShahabAJ2.Sprint2.Task3.V12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #2 | Выполнил: Шахаб А. Дж. | СМАРТб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #2                                                               *");
            Console.WriteLine("* Тема: Вложенные операторы if - else                                     *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #12                                                             *");
            Console.WriteLine("* Выполнил: Шахаб А. Дж. | СМАРТб-25-1                                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая вычисляет значение функции Y для различных  *");
            Console.WriteLine("* интервалов X с использованием вложенных операторов if-else.            *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Введите значение X: ");
            double x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double y;

            if (x > 5)
            {
                y = Math.Pow(x, 2) + Math.Pow((x + 5) / (x - 3), x);
            }
            else if (x == 0)
            {
                y = (Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 3) / (Math.Pow(x, 2) - Math.Sin(Math.Pow(x, 2)) + 5);
            }
            else if (x > -3 && x <= 5)
            {
                if (x == 2)
                {
                    y = Math.Pow(x, 3) - 2 / Math.Pow(x, 2);
                }
                else
                {
                    y = Math.Pow(1 + 3 / Math.Pow(x, 2), x);
                }
            }
            else if (x <= -3)
            {
                y = x + 4 * x - 1 / Math.Pow(x, 2);
            }
            else
            {
                Console.WriteLine("Значение X не попадает ни в один из интервалов функции");
                return;
            }

            y = Math.Round(y, 3);
            Console.WriteLine($"Значение функции Y = {y}");

            Console.ReadKey();
        }
    }
}
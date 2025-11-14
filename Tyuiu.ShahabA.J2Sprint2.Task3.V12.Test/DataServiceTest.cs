using System;
using Tyuiu.ShahabAJ2.Sprint2.Task3.V12.Lib;

namespace Tyuiu.ShahabAJ2.J2Sprint2.Task3.V12.Test;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("*************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("*************************");

        Console.Write("Введите значение X: ");
        double x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("*************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("*************************");

        double result = ds.Calculate(x);
        Console.WriteLine($"Значение Y = {result}");

        Console.ReadKey();
    }
}
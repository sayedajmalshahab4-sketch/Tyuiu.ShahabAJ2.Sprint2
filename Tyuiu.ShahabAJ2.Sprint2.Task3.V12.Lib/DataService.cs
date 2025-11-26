using System;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShahabAJ2.Sprint2.Task3.V12.Lib
{
    public class DataService : ISprint2Task3V12
    {
        public DataService()
        {
        }

        public double Calculate(double x)
        {
            double y;

            if (x > 1)
            {
                y = x + Math.Pow((x + 1) / (x - 1), x);
            }
            else if (x == 0)
            {
                y = Math.Pow(x, 2) - Math.Cos(Math.Pow(x, 2)) + 10;
            }
            else if (-10 <= x && x < 0)
            {
                y = Math.Pow(x, 2) - (1 / Math.Pow(x, 2));
            }
            else if (x < -10)
            {
                y = Math.Pow(x, 3) + (10 / x) - Math.Pow(x, 2);
            }
            else
            {
                throw new ArgumentException($"Значение X = {x} не попадает в области определения функции");
            }

            return Math.Round(y, 3);
        }
    }
}
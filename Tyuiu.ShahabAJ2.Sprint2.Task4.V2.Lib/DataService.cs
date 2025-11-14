using System;
using tyuiu.cources.programming.interfaces.Sprint2;
using Tyuiu.ShahabAJ2.Sprint2.Task4.V2.Lib;
namespace Tyuiu.ShahabAJ2.Sprint2.Task4.V2.Lib;
    public class DataService : ISprint2Task4V2
    {
        public double Calculate(double x, double y)
        {
            double z = (x > y + 3)
                ? (x + 1) / y
                : (y + 5) / (y + 2);

            return Math.Round(z, 3);
        }
    }

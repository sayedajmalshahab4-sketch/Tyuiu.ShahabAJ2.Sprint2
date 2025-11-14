using System;
using tyuiu.cources.programming.interfaces.Sprint2;
using Tyuiu.ShahabAJ2.Sprint2.Task7;
namespace Tyuiu.ShahabAJ2.Sprint2.Task7.V25.Lib
{
    public class DataService : ISprint2Task2V25
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Проверка нахождения точки между линиями y = x и y = -x
            // в области где |y| <= |x|
            bool result = (y <= Math.Abs(x)) && (y >= -Math.Abs(x));

            return result;
        }

        public bool CheckDotInShadedArea(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
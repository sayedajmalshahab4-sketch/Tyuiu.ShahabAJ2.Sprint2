using System;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShahabAJ2.Sprint2.Task7.V1.Lib
{
    public class DataService : ISprint2Task7V1
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            // Проверка находится ли точка в заштрихованной области
            // между линиями y = x и y = -x
            bool isAboveLine1 = (y >= -x);
            bool isAboveLine2 = (y >= x);
            bool isBelowLine1 = (y <= -x);
            bool isBelowLine2 = (y <= x);

            // Для области между y = x и y = -x в первом и третьем квадрантах
            if ((y >= -x && y <= x && x <= 0) || (y >= x && y <= -x && x >= 0))
            {
                return true;
            }

            return false;
        }
    }
}
using System;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.Shahab4.Sprint2.Task1.V30.Lib
{
    public class DataService : ISprint2Task1V30
    {
        public bool[] GetCompareOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            // Используем все операции сравнения и логические операции
            result[0] = (a > b) & (c != d);
            result[1] = (a <= c) | (b == d);
            result[2] = (c < d) ^ (a >= b);
            result[3] = (b != a) && (d > c);
            result[4] = (a == d) || (b < c);
            result[5] = !(c >= a) & (d <= b);

            return result;
        }

        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            throw new NotImplementedException();
        }
    }
}
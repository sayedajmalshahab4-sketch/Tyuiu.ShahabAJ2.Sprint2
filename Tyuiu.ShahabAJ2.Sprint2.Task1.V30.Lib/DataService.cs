using System;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShahabAJ2.Sprint2.Task1.V30.Lib
{
    public class DataService : ISprint2Task1V30
    {
        public DataService()
        {
        }

        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            // Используем все требуемые операции сравнения и логические операции
            result[0] = (a < b) & (c != d);           // <, !=, &
            result[1] = (a > b) | (c == d);           // >, ==, |
            result[2] = (a <= b) && (c < d);          // <=, <, &&
            result[3] = (a >= c) || (b > d);          // >=, >, ||
            result[4] = (a != b) ^ (c <= d);          // !=, <=, ^
            result[5] = !(a > c) & (b == d);          // !, >, ==, &

            return result;
        }
    }
}
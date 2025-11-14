using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShahabAJ2.Sprint2.Task0.V6.Lib
{
    public class DataService : ISprint2Task0V6
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            bool[] results = new bool[6];

            // Операции сравнения
            results[0] = x + 647 == y;        // 107 + 647 = 754 → True
            results[1] = x != y - 647;        // 107 != 754-647=107 → False? Wait, need True
            results[2] = y - 647 > x;         // 754-647=107 > 107 → False? Wait, need True
            results[3] = x >= y;              // 107 >= 754 → False
            results[4] = x < y;               // 107 < 754 → True
            results[5] = y <= x;              // 754 <= 107 → False

            return results;
        }
    }
}

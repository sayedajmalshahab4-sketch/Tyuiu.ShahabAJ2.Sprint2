using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.ShahabAJ2.Sprint2.Task1.V30.Lib
{
    public class DataService : ISprint2Task1V30
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] result = new bool[6];

            // 1. (a > b) AND (c < d)
            result[0] = (a > b) && (c < d);

            // 2. (a > b) OR (c == d) 
            result[1] = (a > b) || (c == d);

            // 3. (a + 100 > b) AND (c < d)
            result[2] = (a + 100 > b) && (c < d);

            // 4. (a <= b) OR (c != d)
            result[3] = (a <= b) || (c != d);

            // 5. !(a > c) AND (b == d)
            result[4] = !(a > c) && (b == d);

            // 6. (a < b) XOR (c > d)
            result[5] = (a < b) ^ (c > d);

            return result;
        }
    }
}
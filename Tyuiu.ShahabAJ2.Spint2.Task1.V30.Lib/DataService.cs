using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShahabAJ2.Spint2.Task1.V30.Lib
{
    public class DataService : ISprint2Task1V30
    {
        public bool[] GetLogicOperations(int a, int b, int c, int d)
        {
            bool[] res = new bool[6];

            // (True, False, True, True, True, False)
            res[0] = (a < b) | (c > d);           // True | False = True
            res[1] = (a == b) & (c < d);          // False & True = False
            res[2] = (a != b) || (c <= d);        // True || True = True
            res[3] = (a < b) && (c != d);         // True && True = True
            res[4] = !(a >= b);                   // !False = True
            res[5] = (a <= b) & (c == d);         // True & False = False

            return res;
        }
    }
}

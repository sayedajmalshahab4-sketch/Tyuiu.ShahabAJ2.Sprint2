using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShahabAJ2.Sprint2.Task3.V12.Lib
{
    public class DataService : ISprint2Task3V12
    {
        public double Calculate(double x)
        {
            double y;

            if (x > 1)
            {
                y = x + Math.Pow((x + 1) / (x - 1), x);
            }
            else if (x == 0)
            {
                y = 1 + Math.Cos(Math.Sqrt(x + 1));
            }
            else if (x > -16 && x < 2)
            {
                if (x == 0)
                {
                    y = 1 + Math.Cos(Math.Sqrt(x + 1));
                }
                else
                {
                    y = Math.Pow(7 + (5 / Math.Pow(x, 2)), x);
                }
            }
            else if (x < -16)
            {
                y = x + 10 * x - (1 / x);
            }
            else
            {
                y = 0; // для x = -16 или x = 2
            }

            return Math.Round(y, 3);
        }
    }
}
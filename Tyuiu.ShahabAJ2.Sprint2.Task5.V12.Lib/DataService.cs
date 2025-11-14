using System;
using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.ShahabAJ2.Sprint2.Task5.V12.Lib
{
    public class DataService : ISprint2Task5V12
    {
       public string FindDateOfPreviousDay(int g, int m, int n)
        {
            int prevDay = n - 1;
            int prevMonth = m;
            int prevYear = g;

            if (prevDay == 0)
            {
                prevMonth--;

                if (prevMonth == 0)
                {
                    prevMonth = 12;
                    prevYear--;
                }

                prevDay = GetDaysInMonth(prevMonth, prevYear);
            }

            string formattedDay = prevDay.ToString().PadLeft(2, '0');
            string formattedMonth = prevMonth.ToString().PadLeft(2, '0');

            return $"{formattedDay}.{formattedMonth}.{prevYear}";
        }

        private int GetDaysInMonth(int month, int year)
        {
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return IsLeapYear(year) ? 29 : 28;
                default:
                    return 30;
            }
        }

        private bool IsLeapYear(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}
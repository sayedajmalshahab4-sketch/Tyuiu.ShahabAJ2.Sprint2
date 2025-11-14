using System;
using tyuiu.cources.programming.interfaces.Sprint2;
using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.ShahabAJ2.Sprint2.Task6.V12.Lib
{
    public class DataService : ISprint2Task6V12
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

                // Использование сокращенной формы оператора switch
                prevDay = prevMonth switch
                {
                    1 or 3 or 5 or 7 or 8 or 10 or 12 => 31,
                    4 or 6 or 9 or 11 => 30,
                    2 => 29, // Високосный год
                    _ => 30
                };
            }

            // Форматирование с нулями для однозначных чисел
            string formattedDay = prevDay.ToString().PadLeft(2, '0');
            string formattedMonth = prevMonth.ToString().PadLeft(2, '0');

            return $"{formattedDay}.{formattedMonth}.{prevYear}";
        }
    }
}
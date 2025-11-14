using Tyuiu.ShahabAJ2.Sprint2.Task0.V6.Lib;
namespace Tyuiu.ShahabAJ2.Sprint2.Task0.V6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("*************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("*************************");

            int x = 107;
            int y = 754;
            Console.WriteLine($"X = {x}");
            Console.WriteLine($"Y = {y}");

            Console.WriteLine();
            Console.WriteLine("*************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("*************************");

            bool[] results = ds.GetCompareOperations(x, y);

            Console.WriteLine("Результаты операций сравнения:");
            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine($"Операция {i + 1}: {results[i]}");
            }

            Console.ReadKey();
        }
    }
}

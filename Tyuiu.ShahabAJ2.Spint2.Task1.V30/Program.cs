using Tyuiu.ShahabAJ2.Spint2.Task1.V30.Lib; 
namespace Tyuiu.ShahabAJ2.Spint2.Task1.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int a = 657;
            int b = 874;
            int c = 14;
            int d = 654;

            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");
            Console.WriteLine($"C = {c}");
            Console.WriteLine($"D = {d}");

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("***************************************************************************");

            bool[] results = ds.GetLogicOperations(a, b, c, d);

            Console.WriteLine("Результаты логических операций:");
            string[] operations = {
                "(A < B) | (C > D)",
                "(A == B) & (C < D)",
                "(A != B) || (C <= D)",
                "(A < B) && (C != D)",
                "!(A >= B)",
                "(A <= B) & (C == D)"
            };

            for (int i = 0; i < results.Length; i++)
            {
                Console.WriteLine($"{operations[i]} = {results[i]}");
            }

            Console.ReadKey();
        }
    }
}

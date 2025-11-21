using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabAJ2.Sprint2.Task1.V30.Lib;

namespace Tyuiu.ShahabAJ2.Sprint2.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();
             
            int a = 657;
            int b = 874;
            int c = 14;
            int d = 654;

            bool[] wait = new bool[6] { true, false, true, true, false, false };
            bool[] res = ds.GetLogicOperations(a, b, c, d);

            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidGetLogicOperationsWithDifferentValues()
        {
            DataService ds = new DataService();

            int a = 100;
            int b = 200;
            int c = 300;
            int d = 400;

            bool[] res = ds.GetLogicOperations(a, b, c, d);

            // Проверяем, что метод возвращает массив из 6 элементов
            Assert.AreEqual(6, res.Length);

            // Проверяем типы данных
            foreach (bool value in res)
            {
                Assert.IsInstanceOfType(value, typeof(bool));
            }
        }
    }
}
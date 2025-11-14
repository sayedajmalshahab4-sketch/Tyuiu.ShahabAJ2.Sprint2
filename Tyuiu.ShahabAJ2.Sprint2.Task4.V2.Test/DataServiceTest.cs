using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabAJ2.Sprint2.Task4.V2.Lib;

namespace Tyuiu.ShahabAJ2.Sprint2.Task4.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCondition1()
        {
            DataService ds = new DataService();
            double x = 10;
            double y = 5;
            // x > y + 3 → 10 > 5+3 → 10 > 8 → True
            // z = (10 + 1) / 5 = 11 / 5 = 2.2
            double wait = 2.2;
            double result = ds.Calculate(x, y);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCondition2()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 8;
            // x > y + 3 → 2 > 8+3 → 2 > 11 → False
            // z = (8 + 5) / (8 + 2) = 13 / 10 = 1.3
            double wait = 1.3;
            double result = ds.Calculate(x, y);
            Assert.AreEqual(wait, result);
        }
    }
}
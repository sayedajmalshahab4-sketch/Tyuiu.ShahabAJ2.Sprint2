using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabAJ2.Sprint2.Task3.V12.Lib;

namespace Tyuiu.ShahabAJ2.Sprint2.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate1()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = 4.444; // x > 1
            double result = ds.Calculate(x);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculate2()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = 1.540; // x == 0
            double result = ds.Calculate(x);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCalculate3()
        {
            DataService ds = new DataService();
            double x = -10;
            double wait = 0.001; // -16 < x < 2
            double result = ds.Calculate(x);
            Assert.AreEqual(wait, result, 0.001);
        }

        [TestMethod]
        public void ValidCalculate4()
        {
            DataService ds = new DataService();
            double x = -20;
            double wait = -219.95; // x < -16
            double result = ds.Calculate(x);
            Assert.AreEqual(wait, result);
        }
    }
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabAJ2.Sprint2.Task3.V12.Lib;

namespace Tyuiu.ShahabAJ2.Sprint2.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateXGreaterThan1()
        {
            DataService ds = new DataService();
            double x = 2;
            double wait = 5.333;
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateXEquals0()
        {
            DataService ds = new DataService();
            double x = 0;
            double wait = 9; // 0 - cos(0) + 10 = 0 - 1 + 10 = 9
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateXBetweenMinus10And0()
        {
            DataService ds = new DataService();
            double x = -5;
            double wait = 24.96; // 25 - (1/25) = 25 - 0.04 = 24.96
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        public void ValidCalculateXLessThanMinus10()
        {
            DataService ds = new DataService();
            double x = -15;
            double wait = -3374.667; // -3375 + (-0.667) - 225
            double res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentException))]
        public void InvalidCalculateXInGap()
        {
            DataService ds = new DataService();
            double x = 0.5; // Не попадает в диапазоны
            ds.Calculate(x);
        }
    }
}
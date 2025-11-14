using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabAJ2.Sprint2.Task7.V1.Lib;

namespace Tyuiu.ShahabAJ2.Sprint2.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea1()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 0.3;
            bool wait = true;
            bool result = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea2()
        {
            DataService ds = new DataService();
            double x = -0.5;
            double y = -0.3;
            bool wait = true;
            bool result = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea3()
        {
            DataService ds = new DataService();
            double x = 0.5;
            double y = 0.6;
            bool wait = false;
            bool result = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea4()
        {
            DataService ds = new DataService();
            double x = -0.5;
            double y = -0.6;
            bool wait = false;
            bool result = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, result);
        }
    }
}
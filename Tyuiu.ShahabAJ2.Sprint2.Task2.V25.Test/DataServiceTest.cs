using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabA.Sprint2.Task2.V25.Lib;

namespace Tyuiu.ShahabA.Sprint2.Task2.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 4;
            int y = 4;
            bool wait = true;
            bool result = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea2()
        {
            DataService ds = new DataService();
            int x = 6;
            int y = 5;
            bool wait = true;
            bool result = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCheckDotNotInShadedArea()
        {
            DataService ds = new DataService();
            int x = 1;
            int y = 1;
            bool wait = false;
            bool result = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCheckDotNotInShadedArea2()
        {
            DataService ds = new DataService();
            int x = 8;
            int y = 8;
            bool wait = false;
            bool result = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, result);
        }
    }
}
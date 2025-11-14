using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabAJ2.Sprint2.Task7.V25.Lib;

namespace Tyuiu.ShahabAJ2.Sprint2.Task7.V25.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 1;
            bool wait = true; // точка между y=x и y=-x
            bool result = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCheckDotNotInShadedArea()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            bool wait = false; // точка выше y=x
            bool result = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidCheckDotInShadedArea2()
        {
            DataService ds = new DataService();
            double x = -2;
            double y = -1;
            bool wait = true; // точка между y=x и y=-x в третьей четверти
            bool result = ds.CheckDotInShadedArea(x, y);
            Assert.AreEqual(wait, result);
        }
    }
}
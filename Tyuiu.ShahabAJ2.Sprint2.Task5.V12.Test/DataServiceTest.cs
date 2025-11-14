using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.ShahabAJ2.Sprint2.Task5.V12.Lib;

namespace Tyuiu.ShahabAJ2.Sprint2.Task5.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay1()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 9;
            int n = 8;
            string wait = "07.09.2024";
            string result = ds.FindDateOfPreviousDay(g, m, n);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDay2()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 1;
            int n = 1;
            string wait = "31.12.2023";
            string result = ds.FindDateOfPreviousDay(g, m, n);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDay3()
        {
            DataService ds = new DataService();
            int g = 2024;
            int m = 3;
            int n = 1;
            string wait = "29.02.2024";
            string result = ds.FindDateOfPreviousDay(g, m, n);
            Assert.AreEqual(wait, result);
        }

        [TestMethod]
        public void ValidFindDateOfPreviousDay4()
        {
            DataService ds = new DataService();
            int g = 2023;
            int m = 3;
            int n = 1;
            string wait = "28.02.2023";
            string result = ds.FindDateOfPreviousDay(g, m, n);
            Assert.AreEqual(wait, result);
        }
    }
}
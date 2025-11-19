using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.Shahab4.Sprint2.Task1.V30.Lib;

namespace Tyuiu.Shahab4.Sprint2.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();
            int a = 657;
            int b = 874;
            int c = 14;
            int d = 654;
            bool[] wait = { true, false, true, true, true, false };
            bool[] result = ds.GetCompareOperations(a, b, c, d);
            CollectionAssert.AreEqual(wait, result);
        }
    }
}
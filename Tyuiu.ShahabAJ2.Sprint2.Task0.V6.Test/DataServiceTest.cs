using Tyuiu.ShahabAJ2.Sprint2.Task0.V6.Lib;
namespace Tyuiu.ShahabAJ2.Sprint2.Task0.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 107;
            int y = 754;
            bool[] wait = { true, true, true, false, true, false };
            bool[] result = ds.GetCompareOperations(x, y);
            CollectionAssert.AreEqual(wait, result);
        }
    }
}

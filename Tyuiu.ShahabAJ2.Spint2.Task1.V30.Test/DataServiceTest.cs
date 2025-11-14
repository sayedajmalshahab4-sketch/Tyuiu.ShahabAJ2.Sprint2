using Tyuiu.ShahabAJ2.Spint2.Task1.V30.Lib;
namespace Tyuiu.ShahabAJ2.Spint2.Task1.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int a = 657;
            int b = 874;
            int c = 14;
            int d = 654;
            bool[] wait = { true, false, true, true, true, false };
            bool[] result = ds.GetLogicOperations(a, b, c, d);
            CollectionAssert.AreEqual(wait, result);
        }
    }
}

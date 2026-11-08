using Microsoft.VisualStudio.TestTools.UnitTesting;
using tyuiu.denisovld.sprint4.Task0.V16.Lib;
namespace tyuiu.denisovld.sprint4.Task0.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[] lol = { 2, 3, 1, 6, 7, 8, 13, 2 };
            int res = ds.GetMultEvenArrEl(lol);
            int exp = 2 * 6 * 8 * 2;
            Assert.AreEqual(res, exp);
        }
    }
}

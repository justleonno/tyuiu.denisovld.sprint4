using Microsoft.VisualStudio.TestTools.UnitTesting;
using tyuiu.denisovld.sprint4.Task5.V29.Lib;

namespace tyuiu.denisovld.sprint4.Task5.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int[,] data = { { 3, -2, 3 }, { 2, -6, 7 }, { 5, -12, -7 } };
            int LOL = 5;
            int count = 0;
            count = ds.Calculate(data);
            Assert.AreEqual(LOL, count);
        }
    }
}

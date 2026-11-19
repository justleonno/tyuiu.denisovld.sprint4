using Microsoft.VisualStudio.TestTools.UnitTesting;
using tyuiu.denisovld.sprint4.Task6.V29.Lib;
namespace tyuiu.denisovld.sprint4.Task6.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string[] lol = { "Весна", "Лето", "Осень", "Зима" };
            Assert.AreEqual(ds.Calculate(lol), 2);
        }
    }
}

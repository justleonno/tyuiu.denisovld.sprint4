using Microsoft.VisualStudio.TestTools.UnitTesting;
using tyuiu.denisovld.sprint4.Task7.V29.Lib;
namespace tyuiu.denisovld.sprint4.Task7.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string lol = "983157642891";
            Assert.AreEqual(ds.Calculate(4, 3, lol), 8 + 6 + 4 + 2 + 8);
        }
    }
}

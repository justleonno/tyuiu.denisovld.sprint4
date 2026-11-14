using Microsoft.VisualStudio.TestTools.UnitTesting;
using tyuiu.denisovld.sprint4.Task3.V18.Lib;
namespace tyuiu.denisovld.sprint4.Task2.V9.Test;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        int[,] data = { { 1, 2, 3 }, { 2, 6, 7 }, { 5, 12, 7 } };
        Assert.AreEqual(ds.Calculate(data), 12);
    }
}

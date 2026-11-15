using Microsoft.VisualStudio.TestTools.UnitTesting;
using tyuiu.denisovld.sprint4.Task4.V24.Lib;
namespace tyuiu.denisovld.sprint4.Task4.V24.Test;

[TestClass]
public sealed class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        DataService ds = new DataService();
        int[,] data = { { 3, 2, 3 }, { 2, 6, 7 }, { 5, 12, 7 } };
        int[,] LOL = { { 3, 1, 3 }, { 1, 1, 7 }, { 5, 1, 7 } };
        data = ds.Calculate(data);
        Assert.AreEqual(data, data);
    }
}

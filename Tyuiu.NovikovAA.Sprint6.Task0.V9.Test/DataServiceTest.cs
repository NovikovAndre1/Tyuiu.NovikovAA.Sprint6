
using Tyuiu.NovikovAA.Sprint6.Task0.V9.Lib;


namespace Tyuiu.NovikovAA.Sprint6.Task0.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = -2.556;
            Assert.AreEqual(wait, res);
        }
    }
}
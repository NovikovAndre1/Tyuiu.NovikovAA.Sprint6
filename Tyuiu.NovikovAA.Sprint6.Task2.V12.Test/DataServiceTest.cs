
using Tyuiu.NovikovAA.Sprint6.Task2.V12.Lib;


namespace Tyuiu.NovikovAA.Sprint6.Task2.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int stopValue = 5;

            int len = stopValue - startValue + 1;

            double[] valueWaitArray;
            valueWaitArray = new double[len];

            // «аполн€ем массив ожидаемых значений
            valueWaitArray[0] = -12.02;
            valueWaitArray[1] = -13.00;
            valueWaitArray[2] = -15.10;
            valueWaitArray[3] = -18.39;
            valueWaitArray[4] = -23.00;
            valueWaitArray[5] = -29.05;
            valueWaitArray[6] = -36.66;
            valueWaitArray[7] = -45.86;
            valueWaitArray[8] = -56.63;
            valueWaitArray[9] = -69.00;
            valueWaitArray[10] = -82.95;

            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
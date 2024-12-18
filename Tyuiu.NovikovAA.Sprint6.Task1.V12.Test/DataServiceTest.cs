
using Tyuiu.NovikovAA.Sprint6.Task1.V12.Lib;


namespace Tyuiu.NovikovAA.Sprint6.Task1.V12.Test
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

            valueWaitArray[0] = -7.27;
            valueWaitArray[1] = -6.60;
            valueWaitArray[2] = -5.90;
            valueWaitArray[3] = -5.20;
            valueWaitArray[4] = -4.50;
            valueWaitArray[5] = -3.79;
            valueWaitArray[6] = -3.08;
            valueWaitArray[7] = -2.3;
            valueWaitArray[8] = -1.64;
            valueWaitArray[9] = -0.91;
            valueWaitArray[10] = -0.18;


            double[] res;
            res = new double[len];
            res = ds.GetMassFunction(startValue, stopValue);
            CollectionAssert.AreEqual(valueWaitArray, res);
        }
    }
}
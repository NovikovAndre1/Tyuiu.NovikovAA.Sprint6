
using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.NovikovAA.Sprint6.Task0.V9.Lib
{
    public class DataService : ISprint6Task0V9
    {
        public double Calculate(int x)
        {
            if (x == 0)
            {
                return 0;
            }
            else
            {
                return Math.Round((4 - Math.Pow(x, 3)) / Math.Pow(x, 2), 3);
            }

        }
    }
}

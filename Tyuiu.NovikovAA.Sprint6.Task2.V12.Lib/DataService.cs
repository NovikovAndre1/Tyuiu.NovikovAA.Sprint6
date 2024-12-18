
using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.NovikovAA.Sprint6.Task2.V12.Lib
{
    public class DataService : ISprint6Task2V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray; // объявляем пустой массив
            int len = (stopValue - startValue) + 1; // вычисляем длину массива
            valueArray = new double[len]; // создаём массив с указанной длинной
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = Math.Cos(x) + x;
                if (denominator == 0)
                {
                    Console.WriteLine($"Деление на ноль при x = {x}.  Результат: NaN");
                    valueArray[count] = 0; //  NaN - не число
                }
                else
                {
                    y = (2 * x + 6) / (Math.Cos(x) + x) - 3;
                    valueArray[count] = Math.Round(y, 2);
                }
                count++;
            }
            return valueArray;
        }
    }
}

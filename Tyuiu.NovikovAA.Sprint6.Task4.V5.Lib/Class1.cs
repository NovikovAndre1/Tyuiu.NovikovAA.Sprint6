
using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.NovikovAA.Sprint6.Task4.V5.Lib
{
    public class Class1 : ISprint6Task4V5
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
                double denominator = (3 * x + 1.2);
                if (denominator == 0)
                {
                    Console.WriteLine($"Деление на ноль при x = {x}.  Результат: NaN");
                    valueArray[count] = 0; //  NaN - не число
                }
                else
                {
                    y = (2 * Math.Sin(x)) / (3 * x + 1.2) + Math.Cos(x) - 7 * x * 2;
                    valueArray[count] = Math.Round(y, 2);
                }
                count++;
            }
            return valueArray;
        }
    }
}

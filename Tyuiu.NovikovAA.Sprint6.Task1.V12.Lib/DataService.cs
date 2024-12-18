﻿
using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.NovikovAA.Sprint6.Task1.V12.Lib
{
    public class DataService : ISprint6Task1V12
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
                double denominator = 2 - x;
                if (denominator == 0)
                {
                    Console.WriteLine($"Деление на ноль при x = {x}.  Результат: NaN");
                    valueArray[count] = double.NaN; //  NaN - не число
                }
                else
                {
                    y = Math.Sin(x) + (Math.Cos(x) + 1) / denominator + 2 * x;
                    valueArray[count] = Math.Round(y, 2);
                }
                count++;
            }
            return valueArray;
        }
    }
}
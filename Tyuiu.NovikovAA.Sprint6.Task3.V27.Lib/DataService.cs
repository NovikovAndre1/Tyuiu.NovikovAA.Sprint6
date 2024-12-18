
using tyuiu.cources.programming.interfaces.Sprint6;


namespace Tyuiu.NovikovAA.Sprint6.Task3.V27.Lib
{
    public class DataService : ISprint6Task3V27
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetUpperBound(0) + 1; // Количество строк
            int columns = matrix.Length / rows;     // Количество столбцов

            // Создаем новую матрицу для хранения результата
            int[,] result = new int[rows, columns];

            // Копируем данные из исходной матрицы в новую
            Array.Copy(matrix, result, matrix.Length);

            // Сортируем только четвертый столбец
            for (int i = 0; i < rows - 1; i++)
            {
                for (int j = i + 1; j < rows; j++)
                {
                    if (result[i, 3] > result[j, 3])
                    {
                        // Меняем только элементы четвертого столбца
                        int temp = result[i, 3];
                        result[i, 3] = result[j, 3];
                        result[j, 3] = temp;
                    }
                }
            }

            return result;
        }
    }
}

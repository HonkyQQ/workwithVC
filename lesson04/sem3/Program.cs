// Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, состоящий из средних
// арифметических значений по строкам двумерного массива.
// Пример
// 2 3 4 3
// 4 3 4 1 => [3 3 5]
// 2 9 5 4

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) // i < rows
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // j < columns
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

double[] AverageElementsRows(int[,] matrix)
{
    double[] array = new double[matrix.GetLength(0)];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        double average = (double)sum / matrix.GetLength(1);
        array[i] = average;
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            Console.Write($"{Math.Round(array[i], 2)}, ");
        }
        else
        {
            Console.Write($"{Math.Round(array[i], 2)}");
        }
    }
    Console.Write("]");
}

int[,] array2d = CreateMatrixRndInt(4, 3, 1, 10);
PrintMatrix(array2d);

double[] resultArray = AverageElementsRows(array2d);
PrintArray(resultArray);
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Clear();
int[,] GetArray(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 2);
        }
    }
    return result;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

Console.WriteLine("введите количество строк");
int pos = int.Parse(Console.ReadLine());
Console.WriteLine("введите количество столбцов");
int col = int.Parse(Console.ReadLine());
double[,] numbers = new double[pos, col];

FillArrayRandomNumbers(numbers);
PrintArray(numbers);
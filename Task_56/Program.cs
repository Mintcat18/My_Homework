// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
Console.Clear();

int[,] GetArray(int rows, int colomns, int minValue, int maxValue)
{
    int[,] result = new int[rows, colomns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
}

void PrintArray(int[,] array)
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

int RowLowElement(int[,] array)
{
    int result = 1;
    int minSumRow = 0;
    int sum = 0;
    for (int m = 0; m < array.GetLength(1); m++)
    {
        minSumRow += array[0, m];
    }
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 1; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < minSumRow)
        {
            minSumRow = sum;
            result = i + 1;
        }
        sum = 0;
    }
    return result;
}

Console.WriteLine("Введите число строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int colomns = int.Parse(Console.ReadLine());

Console.WriteLine("_____________");
int[,] sampler = GetArray(rows, colomns, 0, 10);
PrintArray(sampler);
Console.WriteLine("_____________");
PrintArray(sampler);
Console.WriteLine(RowLowElement(sampler));

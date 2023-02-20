// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
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

void ElemSum(int[,] inArray)
{
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            sum += inArray[i, j];
        }
        double arithmSum = Math.Round(sum / inArray.GetLength(0), 2);
        Console.Write($"{arithmSum},");
    }
}

Console.WriteLine("введите количество строк ");
int pos = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите номер столбца");
int col = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(pos, col, -5, 25);
PrintArray(array);
ElemSum(array);




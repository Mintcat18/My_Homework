// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива.

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
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void OrderToRows(int[,] array)
{
    int temp;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int k = 1; k < array.GetLength(1); k++)
        {
            if (array[i, k] > array[i, k - 1])
            {
                temp = array[i, k - 1];
                array[i, k - 1];
                array[i, k] = temp;
            }
        }
    }
}

Console.WriteLine("Введите число строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int colomns = int.Parse(Console.ReadLine());

Console.WriteLine("_____________");
int[,] sampler = GetArray(rows, colomns, 0, 100);
PrintArray(sampler);
Console.WriteLine("_____________");
OrderToRows(sampler);
PrintArray(sampler);
Console.WriteLine("_____________");
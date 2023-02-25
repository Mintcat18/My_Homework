// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.Clear();

int[,,] GetArray(int rows, int colomns, int height)
{
    int[,,] result = new int[rows, colomns, height];
    int count = 10;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            for (int k = 0; k < height; k++)
            {
                result[i, j, k] = count++;
            }
        }
    }
    return result;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");

        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}

Console.WriteLine("Введите число строк: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число столбцов: ");
int colomns = int.Parse(Console.ReadLine());
Console.WriteLine("Введите высоту: ");
int height = int.Parse(Console.ReadLine());

Console.WriteLine("-------------");
if (rows * colomns * height <= 89)
{
    int[,,] sampler = GetArray(rows, colomns, height);
    PrintArray(sampler);
}
else
{
    Console.WriteLine("условие: целых неповторяющихся двух значных чисел не возможно");
}
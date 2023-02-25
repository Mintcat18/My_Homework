// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

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

int MatrixMultiplication(int[,] firstMatrix, int[,] secondMatrix)
{
    int[,] result = new int[firstMatrix.GetLength(0), secondMatrix.GetLength(1)];
    for (int i = 0; i < firstMatrix.GetLength(0); i++)
    {
        for (int j = 0; i < secondMatrix.GetLength(1); j++)
        {
            int value = 0;
            for (int k =0; k <firstMatrix.GetLength(1); k++)
            {
                value += firstMatrix[i,j]*secondMatrix[k,j];
            }
            result[i,j] = value;
        }
    }
    return result;
}

Console.WriteLine("Матрица 1. Введите число строк: ");
int rowsOne = int.Parse(Console.ReadLine());
Console.WriteLine("Матрица 1. Введите число столбцов: ");
int colomnsOne = int.Parse(Console.ReadLine());

Console.WriteLine("Матрица 2. Введите число строк: ");
int rowsTwo = int.Parse(Console.ReadLine());
Console.WriteLine("Матрица 2. Введите число столбцов: ");
int colomnsTwo = int.Parse(Console.ReadLine());

Console.WriteLine("_____________");
int[,] sampler = GetArray(rowsOne, colomnsOne, 0, 10);
PrintArray(sampler);
Console.WriteLine("_____________");
int[,] samplerTwo = GetArray(rowsTwo, colomnsTwo, 0, 10);
PrintArray(samplerTwo);

Console.WriteLine("_____________");
if(sampler.GetLength(1) == samplerTwo.GetLength(0))
{
    int[,] sum = MatrixMultiplication(sampler, samplerTwo);
    PrintArray(sum);
}
else
{
    Console.WriteLine("данные матрицы не получается перемножить");
}
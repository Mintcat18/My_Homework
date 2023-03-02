// Задача 66: Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
Console.Clear();

int RecursivSum(int m, int n)
{
    if (m == n)
    return n;
    return n + RecursivSum(m, n + 1);
}

Console.WriteLine("Введите положительное число N");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("Введите положительное число M");
int m = int.Parse(Console.ReadLine());
Console.WriteLine($"Сумма элементов от {m} до {n} = {RecursivSum(m, n)}");

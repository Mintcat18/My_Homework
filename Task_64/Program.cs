// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.Clear();

string Recursiv(int n, int m)
{
    if (n == m) return n.ToString();
    else return Recursiv(n, m + 1) + m.ToString();
}

Console.WriteLine("Введите положительное число");
int n = int.Parse(Console.ReadLine());
int m = 1;
Console.WriteLine(Recursiv(n, m));
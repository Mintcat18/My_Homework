﻿// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();

Console.WriteLine("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int K = 1;

while(K <= N)
{
    if(K % 2 == 0)
    {
        Console.Write(K + ", ");
        K ++;
    }
    else
    {
        K++;
    }
}

// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.WriteLine("Введите трехзначное число: ");
int number = int.Parse(Console.ReadLine());

int number2 = number % 100 / 10;

Console.WriteLine($"Вторая цифра от числа {number} равна {number2}: ");
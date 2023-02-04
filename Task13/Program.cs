// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.WriteLine("Введите число:");

int Num = int.Parse(Console.ReadLine()!);

if (Num < 100)
{
    Console.WriteLine("В этом числе 3-я цифра отсутствует");
}
while (Num >= 100)
{
    if (Num < 1000)
    {
        int Number = Num % 10;
        Console.WriteLine("Третья цифра в числе: " + Number);
    }

    Num = Num / 10;
}
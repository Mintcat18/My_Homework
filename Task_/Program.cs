//Подсчитать сумму цифр в числе

Console.Clear();

Console.WriteLine("Введите число ");
int A = int.Parse(Console.ReadLine()!);
int Sum = 0;

while (A > 0)
{
    Sum = Sum + A % 10;
    A = A / 10;
}
Console.WriteLine(Sum);

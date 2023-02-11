//Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите число ");
int num = int.Parse(Console.ReadLine());
int count = 1;
int a = 1;

while (count <= num)
{
    count = count * a;
    Console.Write($"{a} ");
    a++;
}
Console.WriteLine($"{count}");
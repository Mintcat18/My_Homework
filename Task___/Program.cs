// Показать кубы чисел, заканчивающихся на четную цифру

int num = 34;
int a = 1;
int cub = 1;

while (a < num)
{
    cub = a * a * a;
    if(cub % 2 == 0)
    {
        Console.Write($"{a} ");
    }
    a++;
}

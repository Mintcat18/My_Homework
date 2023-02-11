/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
Console.Clear();
double[] GetArray(int size, double minValue, double maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().NextDouble() * (maxValue - minValue) + minValue;
    }
    return result;
}
double Result(double[] inArray)
{
    double min = inArray[0];
    double max = inArray[0];
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] > max)
        {
            max = inArray[i];
        }
        else if (inArray[i] < min)
        {
            min = inArray[i];
        }
    }
    return max;
    return min;
}


double[] array = GetArray(10, -10, 10);
Console.WriteLine(String.Join(", ", array));
double min = Result(array);
double max = Result(array);
Console.WriteLine($"Максимальное = {max}. Минимальное = {min}");


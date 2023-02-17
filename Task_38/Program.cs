/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76*/
Console.Clear();
double[] GetArray(int size, double minValue, double maxValue)
{
    double[] result = new double[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 2);
    }
    return result;
}
double ResultMax(double[] inArray);
{
    double max = inArray[0];
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] > max)

        max = inArray[0];
    }
    return max;
}
double ResultMin(double[] inArray)
{
    double min = inArray[0];
    for (int i = 0; i < inArray.Length; i++)
    {
        if (inArray[i] < min)

            min = inArray[i];
    }
    return min;
}


double[] array = GetArray(10, -10, 10);
Console.WriteLine(String.Join(", ", array));
double min = ResultMax(array);
double max = ResultMin(array);
Console.WriteLine($"Максимальное = {max}. Минимальное = {min}");
Console.WriteLine($"Разница между максимальным и минимальным = {Math.Round(max - min, 2)}");

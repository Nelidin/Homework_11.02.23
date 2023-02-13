// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//                                         [3 7 22 2 78] -> 76


double[] RealNumbers(int size, double minValue, double maxValue)
{
    double[] result = new double[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = Math.Round(new Random().NextDouble() * (maxValue - minValue) + minValue, 2);
    }
    return result;
}

Console.Clear();

double Max(double[] array)
{
    double max = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double Min(double[] array)
{
    double min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double[] array = RealNumbers(5, -10, 100);
Console.WriteLine(String.Join(", ", array));
double max = Max(array);
double min = Min(array);
Console.WriteLine($"Максимальный элемент = {max}, минимальный элемент = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами массива = {Math.Round(max - min, 2)}");

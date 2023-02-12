// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//                                                     [3, 7, 23, 12] -> 19
//                                                     [-4, -6, 89, 6] -> 0

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

Console.Clear();

int SumNumbers(int[] array)
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += array[i];
        }
    }
    return sum;
}

int[] array = GetArray(4, -10, 100);
Console.WriteLine(String.Join(", ", array));
int sum = SumNumbers(array);
Console.WriteLine($"сумму элементов, стоящих на нечётных позициях = {sum}");
// Задайте массив из 12 элементов, заполненный случайными числами
// из промежутка [-9, 9]. Найдите сумму отрицательных и 
// положительных лементов массива.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        res[i] = rnd.Next(minValue, maxValue+1);
    }

    return res;
}

void CountNumber(int[] array)
{
    int positiveSum = 0;
    int negativeSum = 0;

    foreach (int el in array)
    {
        if (el < 0) negativeSum += el;
        if (el > 0) positiveSum += el;
    }

    Console.WriteLine($"Сумма положительных элементов массива = {positiveSum}");
    Console.WriteLine($"Сумма положительных элементов массива = {negativeSum}");

}

int[] array = GetArray(12, -9, 9);
Console.WriteLine(String.Join(" ", array));
CountNumber(array);



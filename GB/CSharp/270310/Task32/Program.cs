// Напишите программу замены элементов массива.
// Положительные элементы замените на соответствующие отрицательные и на оборот


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < size; i++)
        res[i] = rnd.Next(minValue, maxValue+1);

    return res;
}

int[] RevertArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = -array[i];

    return array;
}

int[] array = GetArray(10, -999, 999);
Console.WriteLine(String.Join(" ", array));

array = RevertArray(array);
Console.WriteLine(String.Join(" ", array));
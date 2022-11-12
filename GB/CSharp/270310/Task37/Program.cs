// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// Результат запишите в новом массиве.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < size; i++)
        res[i] = rnd.Next(minValue, maxValue+1);

    return res;
}

int[] DoubleArray(int[] array)
{
    int arrLen = array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1;
    int[] result = new int[arrLen];

    for (int i = 0; i < array.Length / 2; i++)
        result[i] = array[i] * array[array.Length - i - 1];

    if (array.Length % 2 != 0) 
        result[arrLen - 1] = array[arrLen-1];

    return result;

}


int[] array = GetArray(7, 2, 11);
Console.WriteLine(String.Join(" ", array));

int[] result = DoubleArray(array);
Console.WriteLine(String.Join(" ", result));
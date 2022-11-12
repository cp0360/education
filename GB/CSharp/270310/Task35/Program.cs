// Задайте одномерный массив зи 123 случайных чисел.
// Найдите кол-во элементов массива, значения которых 
// лежат в отрезке от 10 до 99

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < size; i++)
        res[i] = rnd.Next(minValue, maxValue+1);

    return res;
}

void FindNumber(int[] array)
{
    int numberCount = 0;
    foreach (int el in array)
        if (el >= 10 && el <= 99) numberCount++;
    
    System.Console.WriteLine($"Кол-во элементов массива от 10 до 99 = {numberCount}");
}

int[] array = GetArray(123, 10, 200);
Console.WriteLine(String.Join(" ", array));
FindNumber(array);
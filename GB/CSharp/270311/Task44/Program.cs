// Не исопльзуя рекурсию, выведите превые N чисел Фиббоначи.
// Первые два числа Фиббоначи: 0 и 1



int[] GetFibArray(int arrLen)
{
    int[] fibArray = new int[arrLen];

    for (int i = 0; i < arrLen; i++)
    {
        if (i == 0 || i == 1) 
            fibArray[i] = i;
        else
            fibArray[i] = fibArray[i-1] + fibArray[i-2];
    }

    return fibArray;
}


Console.WriteLine("Укажите длину последовательности Фиббоначи:");
int N = int.Parse(Console.ReadLine()!);
int[] array = GetFibArray(N);

Console.WriteLine(string.Join(" ", array));

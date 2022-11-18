// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] GenereateArray(int arrLen)
{
    int[] arr = new int[arrLen];
    for (int i = 0; i < arrLen; i++)
    {
        Console.Write($"Укажите {i+1}-е число: ");
        arr[i] = int.Parse(Console.ReadLine()!);
    }

    return arr;
}


int GetCountNumbers(int[] arr)
{
    int cnt = 0;
    for (int i = 0; i < arr.Length; i++)
        if(arr[i] > 0) cnt++;

    return cnt;
}

Console.WriteLine("Укажите сколько чисел нужно обработать: ");
int M = int.Parse(Console.ReadLine()!);
int[] array = GenereateArray(M);
int count = GetCountNumbers(array);

Console.Write($"В массиве [{string.Join(", ", array)}] ");
Console.WriteLine($"{count} элемента(ов) больше 0.");
// Задайте массив. Напишите программу, которая определяет,
// присутствует ли заданное число в массиве


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < size; i++)
        res[i] = rnd.Next(minValue, maxValue+1);

    return res;
}

void FindNumber(int x, int[] arr)
{
    foreach (int el in arr)
    {
        if (el == x)
        {
            Console.WriteLine($"{x} присутствует в массиве.");
            return;
        }
    }

    Console.WriteLine($"{x} нет в массиве.");
}


int[] array = GetArray(10, 10, 50);
Console.WriteLine(String.Join(" ", array));
FindNumber(15, array);
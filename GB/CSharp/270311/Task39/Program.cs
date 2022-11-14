// Напишите программу, которая перевернёт одномерный массив
// (последний элемент будет на перовом месте, а первый на последнем и т.д.)

void ReverseArray(int[] inArray)
{
    int tmp = 0;
    for (int i = 0; i < inArray.Length / 2; i++)
    {
        tmp = inArray[i];
        inArray[i] = inArray[inArray.Length - i - 1];
        inArray[inArray.Length - i - 1] = tmp;
    }
}


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < size; i++)
        res[i] = rnd.Next(minValue, maxValue+1);

    return res;
}

int[] array = GetArray(5, -10, 10);
Console.WriteLine(string.Join(" ", array));
ReverseArray(array);
Console.WriteLine(string.Join(" ", array));
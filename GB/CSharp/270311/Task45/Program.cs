// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.


int[] CreateArray(int arrlen, int minValue, int maxValue)
{
    int[] arr = new int[arrlen];
    Random rnd = new Random();
    for (int i = 0; i < arrlen; i++)
        arr[i] = rnd.Next(minValue, maxValue+1);

    return arr;
}

int[] CopyArray(int[] arrorig)
{
    int[] arrcopy = new int[arrorig.Length];
    for (int i = 0; i < arrorig.Length; i++)
        arrcopy[i] = arrorig[i];

    return arrcopy;
}


Console.WriteLine("Укажите размерность массива:");
int arrLen = int.Parse(Console.ReadLine()!);
int[] origArray = CreateArray(arrLen, 10,99);

Console.Write("Original array: ");
Console.WriteLine(string.Join(" ", origArray));

int[] copyArray = CopyArray(origArray);
Console.Write("Copy array: ");
Console.WriteLine(string.Join(" ", copyArray));

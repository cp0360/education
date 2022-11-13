// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < size; i++)
        res[i] = rnd.Next(minValue, maxValue+1);

    return res;
}

void GetSumEvenPositions(int[] arr)
{
    int total = 0;
    for (int i = 0; i < arr.Length; i+=2)
    {
        total += arr[i];
    }
    System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях в массиве = {total}");
}

Console.Clear();
Console.WriteLine("Укажите размерность массива:");

int arrLenght = int.Parse(Console.ReadLine()!);
int[] array = GetArray(arrLenght, 10, 100);
Console.WriteLine(String.Join(" ", array));
GetSumEvenPositions(array);
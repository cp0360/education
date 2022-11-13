// Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сторировку.


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < size; i++)
        res[i] = rnd.Next(minValue, maxValue+1);

    return res;
}

int[] BoobleSort(int[] arr)
{
    int tmp;
    bool swapped;

    for (int i = 0; i < arr.Length; i++)
    {
        swapped = false;
        for (int j = 0; j < arr.Length - i - 1; j++)
        {
            if(arr[j+1] > arr[j])
            {
                swapped = true;
                tmp = arr[j+1];
                arr[j+1] = arr[j];
                arr[j] = tmp;
            }
        }

        if (!swapped) break; // если небыло перестановок элементов - матсив отсортирован.
    }

    return arr;
}



Console.Clear();
Console.WriteLine("Укажите размерность массива:");

int arrLenght = int.Parse(Console.ReadLine()!);
int[] array = GetArray(arrLenght, 10, 99);
Console.WriteLine(String.Join(" ", array));

int[] reverseSortArray = BoobleSort(array);
Console.WriteLine(String.Join(" ", reverseSortArray));
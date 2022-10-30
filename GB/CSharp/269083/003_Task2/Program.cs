
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
        Console.Write($"{array[i]} ");

    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    int minPosition, temp;
    for (int i = 0; i < array.Length - 1; i++)
    {
        minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
            if (array[j] < array[minPosition])  minPosition = j;

        temp = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temp;
    }

}


int[] arr = {16, 4, 7, 21, 2, 0 , 33, 0, 18};

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);
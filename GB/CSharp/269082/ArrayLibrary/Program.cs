void FillArray(int[] collection)
{
    int lenght = collection.Length;
    int index = 0;

    while (index < lenght)
    {
        collection[index] = new Random().Next(1,10);
        index++;
    }

}

void PrintArray(int[] coll)
{
    int count = coll.Length;
    int postion = 0;

    while (postion < count)
    {
        Console.WriteLine(coll[postion]);
        postion++;
    }
}

int[] array = new int[10];


FillArray(array);
PrintArray(array);
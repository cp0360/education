// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
int[,] GenerateArray(int arrLen)
{
    Random rnd = new Random();
    int[,] array = new int[arrLen, arrLen];

    for (int i = 0; i < arrLen; i++)
        for (int j = 0; j < arrLen; j++)
            array[i, j] = rnd.Next(0, 10);

    return array;
}


void PrintArray(int[,] array)
{
    int arrLen = array.GetLength(0);
    for (int i = 0; i < arrLen; i++)
    {
        for (int j = 0; j < arrLen; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


int[,] SortArray(int[,] array)
{
    int arrLen = array.GetLength(0);
    int tmp;

    for (int a = 0; a < arrLen; a++)
    {
        for (int i = 0; i < arrLen-1; i++)
        {  
            tmp = 0;
            for (int j = 0; j < arrLen-1; j++)
            {
                if(array[a,j] < array[a,j+1])
                {
                    tmp = array[a,j+1];
                    array[a,j+1] = array[a,j];
                    array[a,j] = tmp;
                }
            }
        }
    }
    return array;
}

Console.Clear();
Console.WriteLine("Укажите размерность массива:");
int arrLen = int.Parse(Console.ReadLine()!);

int[,] array = GenerateArray(arrLen);
System.Console.WriteLine("первончальный массив:");
PrintArray(array);

int[,] sortedArray = SortArray(array);
System.Console.WriteLine("отсортированный массив:");
PrintArray(sortedArray);
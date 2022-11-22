// Напишите программу, которая на вход принимает число и ищет его в двумерном массиве. 
// Программа должна возвращать значение позиции (номер строки и столбца) этого элемента или же указание, что такого элемента нет.

int[,] GenerateArray(int N)
{
    int[,] array = new int[N,N];
    Random rnd = new Random();
    
    for (int i = 0; i < N; i++)
        for (int j = 0; j < N; j++)
            array[i, j] = rnd.Next(1,10);
    return array;
}

// поиск всех вхождений числа в массиве
void FindNumber(int[,] arr, int x)
{
    bool inArray = false;
    for (int i = 0; i < arr.GetLength(0); i++)
        for (int j = 0; j < arr.GetLength(1); j++)
            if(arr[i,j] == x)
            {
                inArray = true;
                Console.WriteLine($"{x} -> в сроке {i+1} и столбце {j+1}");
            }

    // если такого числа нет в массиве
    if(inArray == false) Console.WriteLine($"{x} -> такого числа в массиве нет");
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i,j]} ");

        Console.WriteLine();
    }
}


Console.Write("Укажите размерность массива: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write("Укажите число, которе нужно найти: ");
int x = int.Parse(Console.ReadLine()!);

int[,] array = GenerateArray(n);
PrintArray(array);
FindNumber(array, x);

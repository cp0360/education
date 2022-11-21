// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] GenerateArray(int N)
{
    int[,] array = new int[N,N];
    Random rnd = new Random();
    
    for (int i = 0; i < N; i++)
        for (int j = 0; j < N; j++)
        {
            array[i, j] = rnd.Next(1,10);
        }
    return array;
}


void CalculateAverage(int[,] arr)
{

    int n = arr.GetLength(0);
    double[] average = new double[n];
    double tmp;

    for (int i = 0; i < n; i++)
    {
        tmp = 0;
        for (int j = 0; j < n; j++)
            tmp += arr[j,i]; 

        average[i] = Math.Round(tmp / n, 1);
    }

    Console.WriteLine(string.Join("; ", average));
}


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j]} ");    
        }
        Console.WriteLine();
    }
}


System.Console.Write("Укажите размерность массива: ");
int n = int.Parse(Console.ReadLine()!);
int[,] array = GenerateArray(n);
PrintArray(array);
CalculateAverage(array);
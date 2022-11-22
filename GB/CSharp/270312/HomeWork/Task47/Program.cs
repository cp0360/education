// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] GenerateArray(int M, int N, int minVal, int maxVal)
{
    double[,] array = new double[M,N];
    Random rnd = new Random();
    
    for (int i = 0; i < M; i++)
        for (int j = 0; j < N; j++)
            array[i, j] = Math.Round(rnd.NextDouble() * (maxVal - minVal) + minVal, 1);

    return array;
}

void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
            Console.Write($"{arr[i,j]} ");

        Console.WriteLine();
    }
}


Console.Write("Укажите длину массива (n): ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Укажите высоту массива (m): ");
int m = int.Parse(Console.ReadLine()!);

double[,] array = GenerateArray(m, n, 1, 10);
PrintArray(array);
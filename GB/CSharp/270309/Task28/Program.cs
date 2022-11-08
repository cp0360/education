// Напишите программу, которая принимает на вход число N
// и выдаёт произведение числе от 1 до N


int GetProductOfNumbers(int n)
{
    int product = 1;

    for (int i = 1; i <= n; i++)
        product *= i;

    return product;
}

Console.Clear();
Console.WriteLine("Введите число:");
int N = int.Parse(Console.ReadLine()!);
int result = GetProductOfNumbers(N);
Console.WriteLine($"Произведение чисел от 1 до {N} = {result}");

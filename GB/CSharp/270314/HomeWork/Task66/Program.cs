// Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

int CalculateSum(int M, int N)
{
    int total = 0;
    for (int i = M; i <= N; i++)
        total += i;

    return total;
}


Console.Clear();
Console.Write("Укажите значение M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Укажите значение N: ");
int n = int.Parse(Console.ReadLine()!);

if (n < m)
{
    System.Console.WriteLine($"N не може быть меньше M");
    return;
}

int total = CalculateSum(m,n);
System.Console.WriteLine($"M = {m}; N = {n} -> {total}");
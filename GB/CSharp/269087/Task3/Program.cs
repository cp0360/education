// Факториал числа

int FactorialFor(int n)
{
    int result = 1;
    for (int i = 1; i <= n; i++)
        result *= i;
    return result;
}

int FactorialRec(int n)
{
    if (n == 0 || n == 1) return 1;
    else 
        return n * FactorialFor(n - 1);
}

Console.WriteLine(FactorialFor(10));
Console.WriteLine(FactorialRec(10));
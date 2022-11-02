﻿// Сумма чисел от 1 до n

int SumFor(int n)
{
    int result = 0;
    for (int i = 0; i <= n; i++)
        result += i;
    return result;
}

int SumRec(int n)
{
    if (n == 1)
        return 1;
    else
        return n + SumRec(n - 1);
}

Console.WriteLine(SumFor(10));
Console.WriteLine(SumRec(10));

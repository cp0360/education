﻿// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

int Fibonacci(int n)
{
    if(n == 1 || n == 2) return 1;
    else
        return Fibonacci(n-1) + Fibonacci(n-2);
}


Console.Clear();
for (int i = 1; i < 55; i++)
{
    System.Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}
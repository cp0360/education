// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.

void PrintSequence(int n)
{
    if(n==1)
    {
        Console.Write(n);
        return;
    }

    Console.Write($"{n}, ");
    PrintSequence(n-1);
}

Console.Clear();
Console.Write("Укажите длину последовательности: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write($"N = {n} -> \"");
PrintSequence(n);
Console.WriteLine("\"");

// Задача 2
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

int a, b, max;

Console.WriteLine("Введите 1-е число:");
a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите 2-е число:");
b = int.Parse(Console.ReadLine()!);

max = a > b? a : b;
Console.WriteLine($"Максимальное число: {max}");
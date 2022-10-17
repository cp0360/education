// Задача 4
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

int a, b, c, max;

Console.WriteLine("Введите 1-е число:");
a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите 2-е число:");
b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите 3-е число:");
c = int.Parse(Console.ReadLine()!);

max = a;

if (b > max)
    max = b;
if (c > max)
    max = c;

Console.WriteLine($"Максимальное число: {max}");
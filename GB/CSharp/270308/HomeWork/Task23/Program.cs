// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

using System;

void PrintCubeNumber(double x)
{
    double cube;
    String comma = ",";
    Console.Write($"{x} -> ");
    for (int i=1; i<=x; i++)
    {
        if (i == x)     // убираем запятую на последней цифре
            comma = ""; 

        cube = Math.Pow(i, 3);
        Console.Write($"{cube}{comma} ");
    }
    Console.WriteLine("");
}


Console.Clear();
Console.WriteLine("Введите число");
double x = double.Parse(Console.ReadLine()!);
PrintCubeNumber(x);
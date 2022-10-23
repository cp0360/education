// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.

using System;


double GetDistance(double x1, double y1, double x2, double y2)
{
    double X = Math.Pow(x1-x2, 2);
    double Y = Math.Pow(y1-y2, 2);
    double distance = Math.Sqrt(X + Y);
    return distance;
}


// Очистить консоль
Console.Clear();

double x1 = double.Parse(Console.ReadLine()!);
double y1 = double.Parse(Console.ReadLine()!);
double x2 = double.Parse(Console.ReadLine()!);
double y2 = double.Parse(Console.ReadLine()!);

double distance = GetDistance(x1, y1, x2, y2);
Console.WriteLine($"{distance:f2}");
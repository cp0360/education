// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
using System;

// Ф-я вычисляет расстояние отрезка по координатам точек
double GetDistance(int ax, int ay, int az, int bx, int by, int bz)
{
    double axq = Math.Pow(bx - ax, 2);
    double ayq = Math.Pow(by - ay, 2);
    double azq = Math.Pow(bz - az, 2);
    return Math.Sqrt(axq + ayq + azq);
}


int ax, ay, az;
int bx, by, bz;

Console.Clear();
Console.WriteLine("Введите три координаты точки А:");
ax = int.Parse(Console.ReadLine()!);
ay = int.Parse(Console.ReadLine()!);
az = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите три координаты точки B:");
bx = int.Parse(Console.ReadLine()!);
by = int.Parse(Console.ReadLine()!);
bz = int.Parse(Console.ReadLine()!);

double result = GetDistance(ax, ay, az, bx, by, bz);
Console.WriteLine($"{result:f2}");
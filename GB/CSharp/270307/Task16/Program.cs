// Задача 16
// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого

Console.WriteLine("Введите 1-е число:");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите 1-е число:");
int b = int.Parse(Console.ReadLine()!);

String otvet = a * a == b || b * b == a ? "Да" : "Нет";

Console.WriteLine($"Является ли одно число квадратом другого? {otvet}.");

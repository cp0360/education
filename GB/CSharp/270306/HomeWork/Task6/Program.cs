// Задача 6:
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число:");
int x = int.Parse(Console.ReadLine()!);
String answer = "";

answer = x % 2 == 0? "Да" : "Нет";
Console.WriteLine($"{x} является четным? {answer}.");
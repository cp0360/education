// Задача 14.
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23

Console.WriteLine("Введите число:");
int x = int.Parse(Console.ReadLine()!);
String otvet;

if (x % 7 == 0 && x % 23 == 0)
    otvet = "Да";
else
    otvet = "Нет";

Console.WriteLine($"число {x} кратно 7 и 23 -> {otvet}");
// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.WriteLine("Введите число:");
int x = int.Parse(Console.ReadLine());
int tmp = x;
int xsum = 0;

while (tmp > 0)
{
  xsum += tmp % 10;
  tmp /= 10;
}

Console.Clear();
Console.WriteLine($"Сумма чисел числа {x} = {xsum}");

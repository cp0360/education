// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();
Console.WriteLine("Введите число:");
int x = int.Parse(Console.ReadLine()!);
int tmp = x;
int xsum = 0;

while (tmp > 0)
{
  xsum += tmp % 10;
  tmp /= 10;
}

Console.WriteLine($"Сумма чисел числа {x} = {xsum}");
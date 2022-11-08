// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int GetNumberPower(int num, int pow)
{
    int res = 1;
    for (int i = 1; i <= pow; i++)
        res *= num;

    return res;
}


Console.Clear();
Console.WriteLine("Введите два числа через запятую:");

String[] str = Console.ReadLine()!.Split(",");
int number = int.Parse(str[0]);
int pow = int.Parse(str[1]);
int result = GetNumberPower(number, pow);

Console.WriteLine($"{number} в степени {pow} = {result}");
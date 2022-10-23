// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

String CheckPalindrome(int x)
{
    int tmp = x;
    int palindrome = 0;
    int multiplier = 10000; // число, на которе будет умножаться остаток от деления на 10

    while(multiplier >= 1)
    {
        palindrome += (tmp % 10) * multiplier;
        tmp /= 10;
        multiplier /= 10;
    }

    String answer = (palindrome == x) ? "Да" : "Нет";
    return answer;
}


Console.Clear();
Console.WriteLine("Введите 5и значеное число");
int x = int.Parse(Console.ReadLine()!);

// проверка числа на пятизначность.
if (x >= 10000 && x <= 99999)
{
    String result = CheckPalindrome(x);
    Console.WriteLine($"{x} является палиндромом? {result}");
}
else
{
    Console.WriteLine($"{x} не является пятизначным.");
}
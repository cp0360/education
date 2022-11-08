// Напишите прогрмму, которая принимает на вход число 
// и выдает кол-во цифр в числе.


int GetNumberCount(int X)
{
    int count = 0;
    while (X > 0)
    {
        count++;
        X /= 10;
    }
    return count;
}


Console.Clear();
Console.WriteLine("Введите число:");
int x = int.Parse(Console.ReadLine()!);
int result = GetNumberCount(x);
Console.WriteLine($"Количество цифр в числе {x} = {result}");

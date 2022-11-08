// Напишите программу, которая принимает на вход число А
// и выдаёт сумму чисел от 1 до А


int GetSum(int A)
{
    int sum = 0;
    for (int i = 1; i <= A; i++)
    {
        sum += i;
        Console.WriteLine($"{i}: {sum}");
    }
    return sum;
}

Console.Clear();
int a = int.Parse(Console.ReadLine()!);
int result = GetSum(a);
Console.WriteLine(result);
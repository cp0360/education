// Задача 17
// напишите программу, которая принимает на вход координаты точк (X и Y), причем X!=0 и Y!=0
// и выдает номер номер четверти плоскости, в которой находиться эта точка.

int GetQuater(int x, int y)
{
    if (x > 0)
        if (y > 0)
            return 1;
        else
            return 4;
    else
        if (y > 0)
            return 2;
        else
            return 3;
}

// Очистить консоль
Console.Clear();
int X = int.Parse(Console.ReadLine()!);
int Y = int.Parse(Console.ReadLine()!);

int quater = GetQuater(X, Y);
Console.WriteLine(quater);

// Задача 22
// Напишите задачу, которая принимает на вход число (N) 
// и выдаёт таблицу квадратов чисело от 1 до N

int[] GetScuares(int x)
{
    int[] squares = new int[x];
    for (int i=1; i<=x; i++)
        squares[i-1] = i * i;
    return squares;
}

void PrintSquares(int[] squares)
{
    for (int i = 0; i < squares.Length; i++)
        Console.Write($"{squares[i]} ");
    Console.WriteLine("");
}


Console.Clear();
Console.WriteLine("Введите число:");
int x = int.Parse(Console.ReadLine()!);
int[] squares = GetScuares(x);
PrintSquares(squares);

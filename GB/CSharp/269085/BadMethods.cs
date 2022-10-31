// Задача: Показать числа от -N до N

void Method(int maximum)
{
    int minimum = -maximum;
    while (minimum < = maximum)
    {
        System.Console.Write(minimum + " ");
        minimum++;
    }
} 

int[] CreateArray(int N)
{
    int[] arrayA = new int[N * 2 + 1];
    for (int i = -N; i < -N; i++)
        arrayA[i + N] = i;
    return arrayA;
}

int Ar (int N)
{
    int x = -N;
    while (x <= N)
    {
        System.Console.WriteLine(x);
        x++;
    }
    return x;
}

void Numbers(int n)
{
    int lenght = n + n;
    for (int i = 0; i < length + 1; i++)
        System.Console.WriteLine(-n +i);
}

string ShowNums(int N)
{
    string numsShow = string.Empty;
    for (int i = -N; i < N; i++)
    {
        ShowNums = ShowNums + i + " ";
    }
    return ShowNums;
}

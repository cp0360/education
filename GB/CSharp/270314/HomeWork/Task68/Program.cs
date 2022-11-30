// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.


// функция Аккермана
int FAkkerman(int n, int m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return FAkkerman(n - 1, 1);
    else
      return FAkkerman(n - 1, FAkkerman(n, m - 1));
}


Console.Clear();
Console.Write("Укажите значение M: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Укажите значение N: ");
int n = int.Parse(Console.ReadLine()!);



int result = FAkkerman(m, n);
Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {result}");
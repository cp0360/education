double Factorial (int n)
{
    //1! = 1
    //0! = 1
    if(n == 1 || n == 0)  return 1;
    else
        return n * Factorial(n-1);
}

Console.Clear();
Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
double result = Factorial(n);
Console.WriteLine($"Факториал {n} = {result}");
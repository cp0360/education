// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.


void PrintIntersectionPoint(float b1, float k1, float b2, float k2)
{
    if ((k1 * b2 - k2 * b1) == 0)
    {
        Console.WriteLine("Точки пересечения не существует. Прямые параллельны.");
        return;
    }

    float x = (b2-b1) / (k1-k2);
    float y = k1 * x + b1;
    System.Console.WriteLine($"({x},{y})");
}


int b1, k1, b2, k2;

System.Console.Write($"b1 = ");
b1 = int.Parse(Console.ReadLine()!);
System.Console.Write($"k1 = ");
k1 = int.Parse(Console.ReadLine()!);
System.Console.Write($"b2 = ");
b2 = int.Parse(Console.ReadLine()!);
System.Console.Write($"k2 = ");
k2 = int.Parse(Console.ReadLine()!);

PrintIntersectionPoint(b1, k1, b2, k2);

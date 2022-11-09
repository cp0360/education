// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

void PrintArray()
{
    int[] array = new int[8];

    Console.WriteLine("Введите по-очереди 8 чисел.");
    Console.WriteLine();

    for (int i = 0; i <8; i++)
    {
        Console.Write($"Введите {i+1}-e чисело: ");
        array[i] = int.Parse(Console.ReadLine()!);
    }

    Console.Write("[");
    Console.Write(String.Join(", ", array));
    Console.WriteLine("]");
}

Console.Clear();
PrintArray();
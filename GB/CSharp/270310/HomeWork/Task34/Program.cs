// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.


int GetNumberEvenElements(int arrLenght)
{
    int evenCount = 0;
    int element;
    int[] array = new int[arrLenght];


    Random rnd = new Random();
    for (int i = 0; i < arrLenght; i++)
    {
        element = rnd.Next(100,1000); 
        array[i] = element;
        
        if (element % 2 == 0) evenCount ++;
    }

    Console.Write("[");
    Console.Write(String.Join(", ", array));
    Console.WriteLine("]");

    return evenCount;
}


Console.Clear();
Console.WriteLine("Укажите размерность массива:");

int arrLenght = int.Parse(Console.ReadLine()!);
int result = GetNumberEvenElements(arrLenght);

Console.WriteLine($"В массиве четных элементов: {result}");

// Напишите программу, которая выводит массив из 8и элементов,
// заполненный нулями и единицами в случайном порядке.


int[] GetRandomArray()
{
    int[] arr = new int[8];
    for (int i = 0; i < 8; i++)
        arr[i] = new Random().Next(0,2);

    return arr;
}

int[] result = GetRandomArray();

//Console.Clear();
Console.Write("[");
Console.Write(String.Join(", ", result));
Console.WriteLine("]");


// вариант от препода
//Conosole.Write(String.Join(«,», array))
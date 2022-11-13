// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double[] GetDoubleArray(int arrLenght, double minValue, double maxValue)
{
    double[] dArray = new double[arrLenght];
    double rDouble;
    var rnd = new Random();

    for (int i = 0; i < arrLenght; i++)
    {
        rDouble = rnd.NextDouble();
        dArray[i] = rDouble * (maxValue - minValue) + minValue;
    }

    return dArray;
}

double GetMaxElement(double[] arr)
{
    // если передан пустой массив, возвращаем 0
    if (arr.Length == 0)
        return 0;
    
    double maxValue = arr[0];
    for (int i = 1; i < arr.Length; i++)
        if (arr[i] > maxValue) maxValue = arr[i];

    return maxValue;
}

double GetMinElement(double[] arr)
{
    // если передан пустой массив, возвращаем 0
    if (arr.Length == 0)
        return 0;
    
    double minValue = arr[0];
    for (int i = 1; i < arr.Length; i++)
        if (arr[i] < minValue) minValue = arr[i];

    return minValue;
}


Console.Clear();
Console.WriteLine("Укажите размерность массива:");

int arrLenght = int.Parse(Console.ReadLine()!);
double[] array = GetDoubleArray(arrLenght, 10.1, 100.1);
Console.WriteLine(String.Join(" ", array));

double maxElement = GetMaxElement(array);
double minElement = GetMinElement(array);

Console.WriteLine($"Разница между {maxElement} и {minElement} = {maxElement - minElement}");
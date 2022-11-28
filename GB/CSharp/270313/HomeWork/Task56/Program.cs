// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] GenerateArray(int arrLen)
{
    Random rnd = new Random();
    int[,] array = new int[arrLen, arrLen];

    for (int i = 0; i < arrLen; i++)
        for (int j = 0; j < arrLen; j++)
            array[i, j] = rnd.Next(0, 10);

    return array;
}


void PrintArray(int[,] array)
{
    int arrLen = array.GetLength(0);
    for (int i = 0; i < arrLen; i++)
    {
        for (int j = 0; j < arrLen; j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int CaluclateMinimumRow(int[,] array)
{
    int rowNumber = 1;
    int total = 0;
    int arrLen = array.GetLength(0);

    // проверка на пустой массив
    if(arrLen == 0)
        return 0;


    //  подсчет суммы чисел для 1-й строки
    for (int i = 0; i < arrLen; i++)
        total += array[0,i];
    
    // подсчет суммы чисел для остальных строк
    for (int i = 1; i < arrLen; i++)
    {
        int tmp = 0;
        for (int j = 0; j < arrLen; j++)
            tmp += array[i, j];
        
        // если сумма чисел из текущей строки меньше - делаем строку минимальной
        if(tmp < total)
        {
            total = tmp;
            rowNumber = i+1;
        }
    }

    return rowNumber;
}

Console.Clear();
Console.WriteLine("Укажите размерность массива:");
int arrLen = int.Parse(Console.ReadLine()!);

int[,] array = GenerateArray(arrLen);
PrintArray(array);
int minRow = CaluclateMinimumRow(array);
Console.WriteLine( $"{minRow} строка.");
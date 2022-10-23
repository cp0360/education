// Задача 18
// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат в этой четверти (x и y)

void GetInfo(int quater)
{
    switch(quater)
    {
        case 1:
            Console.WriteLine("X больше 0 и Y больше 0");
            break;
        case 2:
            Console.WriteLine("X меньше 0 и Y больше 0");
            break;
        case 3:
            Console.WriteLine("X меньше 0 и Y меньше 0");
            break;
        case 4:
            Console.WriteLine("X больше 0 и Y меньше 0");
            break;
        default:
            Console.WriteLine("Не верно указана четверть");
            break;
    }
}

// Очистить консоль
Console.Clear();
Console.WriteLine("Введите номер четверти");
int quater = int.Parse(Console.ReadLine()!);
GetInfo(quater);
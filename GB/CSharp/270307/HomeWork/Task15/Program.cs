// Задача 15
// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день


int dayOfWeek;
String answer;

Console.WriteLine("Введите день недели:");

// Проверяем на корректность введенного дня недели.
// Не даем выйти из цикла до тех пор, пока не будет указан корректный день недели.
while (true)
{
    dayOfWeek = int.Parse(Console.ReadLine()!);

    if (dayOfWeek >= 1 && dayOfWeek <= 7)
        break;
    else
        Console.WriteLine("Не корректно введен день недели. Введите от 1 до 7.");
}

// Проверяем на принадлежность введенного дня к выходным.
if (dayOfWeek == 6 || dayOfWeek == 7)
    answer = "Да";
else
    answer = "Нет";

Console.WriteLine($"{dayOfWeek}й день недели является выходным? {answer}.");
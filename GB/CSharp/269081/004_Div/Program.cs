double numberA = new Random().Next(10, 100);
Console.WriteLine($"1-е число: {numberA}");

double numberB = new Random().Next(10, 100);
Console.WriteLine($"2-е число: {numberB}");

double result = numberA / numberB;
Console.WriteLine($"Результат деления {numberA} на {numberB} = {result}");

// Пример №1. Переделан пример из antipattern.cs с описанием констант и универсальной логикой

string caption = "Intensive C# Demo text";
int screenWidthPosition = (Console.WindowWidth - caption.length) / 2;
int screenHeightPosition = Console.WindowHeight / 2;

// Вызов метода без именнованных парамтеров
DrawText(caption, screenWidthPosition, screenHeightPosition);
// Вызов метода с именованными параметрами
DrawText(
    text: caption,
    left: screenWidthPosition,
    top: screenHeightPosition
);

// Пример №2. Перивичная инциализация переменных
stgring label = string.Empty;
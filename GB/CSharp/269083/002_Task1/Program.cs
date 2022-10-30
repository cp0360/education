//===== Работа с текстом
// Дан текст. В тексте нужно все пробелы заменить чёрточками.
// Маленькие буквы "к" заменить большими "К"
// большие "С" заменить на маленькие "с"

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
//  s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result += $"{newValue}";
        else result += $"{text[i]}";
    }

    return result;
}


Console.Clear();
text = Replace(text, ' ', '|');
Console.WriteLine(text);

text = Replace(text, 'к', 'К');
Console.WriteLine(text);

text = Replace(text, 'С', 'с');
Console.WriteLine(text);
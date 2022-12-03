// Что такое методы и для чего они нужны
// Нам нужно вывести на экран имя языка

void SayLang(string name)
{
    Console.WriteLine($"Язык {name}"); // $ - Интерполяция строк!
}

SayLang("JS");

SayLang("Python");

SayLang("C#");

SayLang("Java");

string lang = "Russian"; // Передеаем иную переменную string

SayLang(lang); // Получаем на выходе переменну string, которую задали выше, а не ту которая указана в методе 
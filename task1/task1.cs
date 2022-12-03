// Что такое методы и для чего они нужны
// Нам нужно вывести на экран имя языка

// Пример метода =======================================================================

// void SayLang(string name)
// {
//     Console.WriteLine($"Язык {name}"); // $ - Интерполяция строк!
// }

// SayLang("JS");

// SayLang("Python");

// SayLang("C#");

// SayLang("Java");

// string lang = "Russian"; // Передеаем иную переменную string

// SayLang(lang); // Получаем на выходе переменну string, которую задали выше, а не ту которая указана в методе 


// Еще один пример =====================================================================

// int SayNum(int num1, int num2) // Далее подставляет значения, num1 = 2, num2 = 3
// {
//     if (num1 > num2) // Выполняет условия if
//     {
//         return num1;
//     }
//     else
//     {
//         return num2; // Возвращает num2, так как num2 больше num1
//     }
// }

// //Возвращаясь обратно программа принимает значение num2 в переменную x, т.е int x = 3;
// int x = SayNum(2, 3); // Программа доходит до этого места и возвращается к методу наверх

// Console.WriteLine(x); // Выдаем х на экран

// Еще один пример =====================================================================

int SayNum(int num1, int num2) 
{
    if (num1 > num2) 
    {
        return num1;
    }
    else
    {
        return num2; 
    }
}


int x = SayNum(2, 3); 

Console.WriteLine(x); 

Console.WriteLine(SayNum(5, 7));

int x1 = 10;
int x2 = 17;
int x3 = SayNum(x1 , x2);
Console.WriteLine(x3);
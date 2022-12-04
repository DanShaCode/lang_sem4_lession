// Принимаем на вход число
// Выдаем количество цифр в числе

void CountNum(int num)
{
int count = 1;
if (num > 9)
{
    while (num > 9)
{
    num = num / 10;
    count++;
    if (num <= 1)
    {
        Console.WriteLine("Количество цифр в числе: " + count);
    }
}
}
else
{
    int one = 1;
    if (num > 0 && num < 10)
    {
        Console.WriteLine("Количество цифр в числе: " + one);
    }
}
}

Console.WriteLine("Данная программа принимает число и на выходе выдает количество цифр в числе.");
Console.Write("Пожалуйста, введите любое целое число больше 0: ");
int num = Convert.ToInt32(Console.ReadLine());

CountNum(num);
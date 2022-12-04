// Принимаем на вход число
// Выдаем количество цифр в числе

// double num1 = 123 / 10; // 1
// double num2 = 12 / 10; // 2
// double num3 = 1 / 10; // 3

// Console.WriteLine(num1);
// Console.WriteLine(num2);
// Console.WriteLine(num3);

int num = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (num > 9)
{
    while (num > 9)
{
    num = num / 10;
    count++;
    if (num <= 1)
    {
        Console.WriteLine(count);
    }
}
}
else
{
    int one = 1;
    if (num > 0 && num < 10)
    {
        Console.WriteLine(one);
    }
}

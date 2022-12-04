// Принимаем на вход число N
// Выдаем произведение чисел от 1 до N

int num = Convert.ToInt32(Console.ReadLine());

void SplitToArray(int number)
{
    if (num > 0 && num < 10)
    {
        int count = 1;
        int multiNumOne = 1;
        int index = 0;
        while(index < num - 1)
        {
            multiNumOne = multiNumOne * (count + 1);
            count++;
            index++;
        }
        Console.WriteLine(multiNumOne);
    }
    if (num > 9 && num < 100)
    {
    int num1 = num / 10;
    int num2 = num % 10;
    int res = num1 * num2;
    Console.WriteLine(res);
    }
    if (num > 99 && num < 1000)
{
    int num1 = num / 100;
    int num2 = (num / 10) % 10;
    int num3 = num % 10;
    int res = num1 * num2 * num3;
    Console.WriteLine(res);
}
}

SplitToArray(num);
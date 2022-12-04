// Принимаем на вход число N
// Выдаем произведение чисел от 1 до N

Console.WriteLine("Данная программа выводит произведение чисел от 1 до N");
Console.Write("Введите число (от 0 до 33): ");
int num = Convert.ToInt32(Console.ReadLine());

void multiNum(int number)
{
    if (num > 0 && num < 33)
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
        Console.WriteLine("Произведение чисел = " + multiNumOne);
    }
    else
    {
        Console.WriteLine("Ошибка ввода. Введите число от 0 до 33.");
    }
   
}

multiNum(num);
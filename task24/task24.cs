// Принимаем число
// Выдаем сумму чисел от 1 до А

void FillArray(int[] collection) 
{
    int length = collection.Length;
    int index = 0;
    int num = 0;
    while (index < length)
    {
        collection[index] = num + 1;
        index++;
        num++;
    }
}

Console.WriteLine("Данная программа принимает число А и на выходе выдает сумму чисел от 1 до А");
Console.Write("Введите число А: ");
int number = Convert.ToInt32(Console.ReadLine());

int [] array = new int [number];

FillArray(array);

int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    sum = sum + array[i];
}

Console.WriteLine("Сумма чисел = " + sum);

// !!! .НАДО СРОЧНО РАЗОБРАТЬСЯ С МЕТОДАМИ. !!!

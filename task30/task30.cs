// Создай массив заполненный 0 и 1 в случайном порядке.

void FillArray (int[] array)
{
    int length = array.Length;
    int index = 0;
    for (index = 0; index < array.Length; index++)
    {
        array[index] = new Random().Next(0,2);
    }
}

void PrintArray (int[] print)
{
    int length = print.Length;
    int index = 0;
    string space = " ";
    Console.Write("Массив состоящий из восьми элементов, заполненный нулями и единицами в случайном порядке: ");
    for (index = 0; index < print.Length; index++)
    {
        Console.Write(print[index] + space);
    }
}

int[] numbers = new int[8];

FillArray(numbers);
PrintArray(numbers);
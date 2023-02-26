// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int ReadNumber(string msg)
{
    Console.WriteLine(msg);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int [] GetRandomArray(int length, int minValue, int maxValue)
{
    int [] array = new int[length];

    for (int i=0; i < array.Length; i++)
    {
        array[i] = Random.Shared.Next(minValue, maxValue + 1);
    }
    return array;
}

int AnEvenNumber(int[] array)
{
    int count = 0;

    for (int i = 0; i<array.Length; i++)
    {
        int n = array[i];
        if (n % 2 == 0)
        {
            count += 1;
        }        
    }
    return count;
}

int length = ReadNumber("Введите длинну массива: ");
int minValue = ReadNumber("Введие минимальное значение массива: ");
int maxValue = ReadNumber("Введие максимальное значение массива: ");

int[] myArray = GetRandomArray(length, minValue, maxValue);
int count = AnEvenNumber(myArray);
Console.WriteLine($"[{string.Join(", ", myArray)}]");
Console.WriteLine(count);
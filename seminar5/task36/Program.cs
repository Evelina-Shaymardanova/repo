// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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

int SumElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i= i+2)
    {
        sum = sum + array [i];
    }
    return sum;
}

int length = ReadNumber("Введите длинну массива: ");
int minValue = ReadNumber("Введие минимальное значение массива: ");
int maxValue = ReadNumber("Введие максимальное значение массива: ");

int[] myArray = GetRandomArray(length, minValue, maxValue);
int sum = SumElements(myArray);
Console.WriteLine($"[{string.Join(", ", myArray)}]"); // выводит на экран массив
Console.WriteLine(sum);
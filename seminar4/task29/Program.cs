// Напишите программу, которая задаёт массив из 8 элементов и выводит их 
// на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]


int[] GetRandomArray(int length, int minValue, int maxValue)
{
    int[] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array [i] = Random.Shared.Next(minValue, maxValue+1);
    }
    return array;
}

int length = 8;
int minValue = 1;
int maxValue = 100;

int [] myArray= GetRandomArray(length, minValue, maxValue);
Console.WriteLine($"[{string.Join(", ", myArray)}]");
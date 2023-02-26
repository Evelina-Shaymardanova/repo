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

int [] myArray= GetRandomArray(8, 1, 100);
Console.WriteLine($"[{string.Join(", ", myArray)}]");
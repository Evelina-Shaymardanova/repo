// Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


int ReadNumber(string msg)
{
    Console.WriteLine(msg);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int [] MyArray(int length, int rightBorder, int leftBorder)
{
    int [] arr = new int [length];
    for (int i = 0; i < length; i++)
    {
        arr [i] = Random.Shared.Next(rightBorder, leftBorder + 1);
    }
    return arr;
}

int CountArr(int [] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 10 && arr[i] < 99)
        {
            count += 1;
        }
    }
    return count;
}

int length = 123;
int rightBorder = ReadNumber("Введите число правого края массива: ");
int leftBorder = ReadNumber("Введите число левого края массива: ");

int [] arr = MyArray(length, rightBorder, leftBorder);

Console.WriteLine($"[{string.Join("," , arr)}]");

int count = CountArr(arr);
Console.WriteLine(count);
// Напишите программу замена элементов массива:
// положительные элементы замените на соответствующие отрицательные, и наоборот.

// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

int ReadNumber(string msg)
{
    Console.WriteLine(msg);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int [] MyArray(int length, int minValue, int maxValue)
{
    int [] arr = new int [length];

    for (int i = 0; i < length; i++)
    {
        arr [i] = Random.Shared.Next(minValue, maxValue + 1);
    }
    return arr;
}

void MyArr(int [] arr)
{
    for (int i = 0 ; i < arr.Length; i++)
    {
        arr [i] = -1 * arr[i];
    }
}

int length = ReadNumber("Введите длину массива: ");
int minValue = ReadNumber("Введие минимальное значение массива: ");
int maxValue = ReadNumber("Введие максимальное значение массива: ");

int [] arr = MyArray(length, minValue, maxValue);
Console.WriteLine($"[{string.Join(", ", arr)}]");
MyArr(arr);

Console.WriteLine($"[{string.Join(", ", arr)}]");
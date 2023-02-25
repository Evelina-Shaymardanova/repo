// Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int ReadNumber(string msgToUser)
{
    Console.WriteLine(msgToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int Degrees(int a, int b)
{
    int degrees = 1;
    for (int i = 0; i < b; i++)
    {
        degrees *= a;
    }
    return degrees;
}

int a = ReadNumber("Введите число a: ");
int b = ReadNumber("Введите число b");
Console.WriteLine($"{Degrees(a, b)}");

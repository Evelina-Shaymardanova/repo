// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber(string msgToUser)
{
    Console.WriteLine(msgToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int SumCount(int a)
{
    int sum = 0;
    while (a>0)
    {
        sum += a%10;
        a = a / 10;
    }
    return sum;
}

int usenumber = ReadNumber("Введите число a");
int result = SumCount(usenumber);
Console.WriteLine(result);
// Напишите программу, которая принимает на вход трехзначное число и на выходе
// показывает вторую цифру этого числа

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 10)
{
    Console.WriteLine("Error");
}
else
{
    while (num >= 100)
    {
        num = num / 10;
    }
    Console.WriteLine(num % 10);
}
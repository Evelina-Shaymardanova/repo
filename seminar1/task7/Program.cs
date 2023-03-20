// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает последнюю цифру этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int length = number.ToString().Length;

if (length==3)
{
    Console.WriteLine(number % 10);
}
else 
{
    Console.WriteLine("Число не является трехзначным!");
}
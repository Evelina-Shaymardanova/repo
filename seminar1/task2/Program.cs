// Напишите программу, которая на вход принимает два числа и выдает, 
// какое число большее, а какое меньшее.

// a = 5; b = 7; -> max = 7
// a = 2; b = 10; -> max = 10
// a = -9; b = -3; -> max = -3

Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число");
int numberB = Convert.ToInt32(Console.ReadLine());
int max = 0;

if (numberA > numberB)
{
    Console.WriteLine(max = numberA);
}
else if (numberA < numberB)
{
    Console.WriteLine(max = numberB);
}
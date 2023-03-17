// Напишите программу, которая на вход принимает два числа и проверяет, 
// является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.WriteLine("Введите число в возведенный в квадрат: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число, которое надо сравнить для проекрки: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a == Math.Pow(b,2))
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
// Напишите программу, которая на вход принимает чилсло и выдает, является ли число 
// четным(делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число");
int number1 = Convert.ToInt32(Console.ReadLine());

if (number1 % 2 == 0) Console.WriteLine("да");

else Console.WriteLine("нет");

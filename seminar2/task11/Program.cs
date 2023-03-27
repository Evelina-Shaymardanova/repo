// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.

// 456 -> 46
// 782 -> 72
// 918 -> 98

int num = Random.Shared.Next(100,1000);
Console.WriteLine(num);

int num1 = (num/100)*10;
int num2 = (num%10)+num1;
Console.WriteLine(num2);
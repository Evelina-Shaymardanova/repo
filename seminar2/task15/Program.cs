// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот деньвыходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите число");
int numDay = Convert.ToInt32(Console.ReadLine());
if (numDay > 7)
{
    Console.WriteLine("Нет");
}    
else if (numDay < 6)
{
    Console.WriteLine("Нет");
}
else if (numDay == 6)
{
    Console.WriteLine("Да");
}
else if (numDay == 7)
{
    Console.WriteLine("Да");
}


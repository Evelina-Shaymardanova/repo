// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int n = 8;
int m = 4;
int sum = 0;
PrintNumber(n, m, sum);

void PrintNumber(int n, int m, int sum)
{
    if (m > n)
    {
       Console.Write(sum); 
       return;
    }
    sum = sum + (m++);
    PrintNumber(n, m, sum);
}
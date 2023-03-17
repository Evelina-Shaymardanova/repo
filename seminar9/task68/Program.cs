// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9

Console.WriteLine("Введите начальное число M:");
uint numberM = uint.Parse(Console.ReadLine()!);

Console.WriteLine("Введите начальное число N:");
uint numberN = uint.Parse(Console.ReadLine()!);

///Метод вычисления функции Аккермана:
uint AckermannFunction (uint numberM, uint numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
return AckermannFunction(numberM, numberN);
}

Console.WriteLine($"Функция Аккермана для чисел A({numberM},{numberN}) = {AckermannFunction(numberM, numberN)}");


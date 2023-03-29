// Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите номер координатной четверти: ");
int coordinata = Convert.ToInt32(Console.ReadLine());

if (coordinata == 1)
{
    Console.WriteLine("Диапозон точек первой четверти: x > 0 и y > 0");
}
else if (coordinata == 2)
{
    Console.WriteLine("Диапозон точек второй четверти: x < 0 и y > 0");
}
else if (coordinata == 3)
{
    Console.WriteLine("Диапозон точек третьей четверти: x < 0 и y < 0");
}
else if (coordinata == 4)
{
    Console.WriteLine("Диапозон точек четвертой четверти: x > 0 и y < 0");
}
else
{
    Console.WriteLine("Нет такой координатной четверти!");
}

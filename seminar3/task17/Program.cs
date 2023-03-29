//  Напишите программу, которая принимает на вход координаты точки (X и Y),
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


Console.WriteLine("Введите координату x: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координату y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Первая координатная четверь");
}
else if(x < 0 && y > 0)
{
    Console.WriteLine("Вторая координатная четверть");
}
else if(x <0 && y < 0)
{
    Console.WriteLine("Третья координатная четверть");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("Четвертая координатная четверть");
}
else 
{
    Console.WriteLine("Нет такой координатной четверти");
}
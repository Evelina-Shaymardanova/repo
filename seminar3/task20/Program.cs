// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,10
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точки a по оси x: ");
double ax = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки a по оси y: ");
double ay = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки b по оси x: ");
double bx = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты точки b по оси y: ");
double by = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow(bx-ax, 2)+ Math.Pow(by-ay, 2)));

// import math
// distans = math.sqrt((ax-bx)**2+(ay-by)**2)
// print(f'Растояние между точкой A до точки B = {distans}' )
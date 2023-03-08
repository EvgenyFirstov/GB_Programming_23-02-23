/*
Задача №21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21

Формула вычисления расстояния между двумя точками A(xa, ya) и B(xb, yb) на плоскости: AB = √((xb - xa)2 + (yb - ya)2).
*/

Console.WriteLine("Введите координаты первой точки:");
Console.Write("х = ");
int x1 = int.Parse(Console.ReadLine());
Console.Write("y = ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки:");
Console.Write("х = ");
int x2 = int.Parse(Console.ReadLine());
Console.Write("y = ");
int y2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt((x2-x1)*(x2-x1) + (y2-y1)*(y2-y1));
Console.Write($"Растояние между точками: {Math.Round(result, 2, MidpointRounding.ToNegativeInfinity)}");
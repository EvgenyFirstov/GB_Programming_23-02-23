﻿/*
Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
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

Console.WriteLine("Введите координаты третьей точки:");
Console.Write("х = ");
int z1 = int.Parse(Console.ReadLine());
Console.Write("y = ");
int z2 = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.Write($"Растояние между точками в пространстве: {Math.Round(result, 2, MidpointRounding.ToNegativeInfinity)}");
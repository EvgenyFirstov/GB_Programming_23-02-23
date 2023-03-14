/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
*/

// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

bool TriangleExist(int[] sides)
{
    return (sides[0] < sides[1] + sides[2]) && (sides[1] < sides[0] + sides[2]) && (sides[2] < sides[0] + sides[1]);
}

Console.Write("Введите 3 числа(длина стороны потенциального треугольника) через пробел: ");

int[] number = Console.ReadLine().Split().Select(int.Parse).ToArray();

if (TriangleExist(number))
{
    Console.WriteLine("Может существовать");
}
else
{
    Console.WriteLine("Не может существовать");
}


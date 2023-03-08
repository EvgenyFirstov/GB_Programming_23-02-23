/*
Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16
*/

double GetStep(double a, double b)
{
    
    double result = Math.Pow(a, b);
    return result;
}

Console.Write("Введите первое число: ");
double a = double.Parse(Console.ReadLine());

Console.Write("Введите второе число: ");
double b = double.Parse(Console.ReadLine());

double result = GetStep(a, b);
Console.WriteLine($"Число {a} в степени {b} = {result}");
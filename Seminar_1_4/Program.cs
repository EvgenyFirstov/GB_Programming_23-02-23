// Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

Console.Write("Введите число: ");
int digit = int.Parse(Console.ReadLine());
int line = digit % 10;
Console.WriteLine(line);

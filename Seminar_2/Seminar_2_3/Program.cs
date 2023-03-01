/*
Задача 12: Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4
16, 4  -> кратно
*/

Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);

if (numberA % numberB == 0)
{
    Console.WriteLine($"{numberA} катно {numberB}");
}
else
{
    Console.WriteLine($"Не кратно, так как остаток {numberA % numberB}");
}
/*
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

/*
Console.WriteLine("Введите трехначное число: ");
string number = Console.ReadLine();

if (number.Length != 3)
{
    Console.WriteLine("Введено не трехзнаное число!");
}
else
{
    Console.WriteLine($"Вторая цифра числа: {number[1]}");
}
*/

Console.WriteLine("Введите трехначное число: ");
int number = int.Parse(Console.ReadLine());

int Length = number.ToString().Length;

if (Length == 3)
{
	int result = (number / 10) % 10;
	Console.WriteLine($"Вторая цифра числа: {result}");
}
else
{
	Console.WriteLine("Введено не трехзнаное число!");
}
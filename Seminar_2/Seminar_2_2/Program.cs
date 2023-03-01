/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
Например, 456 -> 46     782 -> 72   918 -> 98
*/

// Первый метод (математический)
int number = new Random().Next(100, 1000);
Console.WriteLine($"Сгенерированное число: {number}");


int result = (number / 100) * 10 + number % 10;

Console.WriteLine($"Число без второй цифры имеет вид: {result}");
// или
// Console.WriteLine($"Число без второй цифры имеет вид: {number / 100}{number % 10}");

/*
// Второй метод (строковый)
Console.WriteLine("Введи трёхзначное число: ");
string number = Console.ReadLine()!;
if (number.Length != 3)
{
    Console.WriteLine("Введено неверное число!");
}
else
{
    Console.WriteLine($"Число без второй цифры имеет вид: {number[0]}{number[2]}");
}
*/
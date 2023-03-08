/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
*/

int GetSumNumber(int number)
{
    int sum = 0;
    int pop = 0;

    while (number != 0)
    {
        pop = number % 10;
        number = number / 10;
        sum = sum + pop;
    }
    return sum;
}

Console.Write("Введите число: ");
int a = int.Parse(Console.ReadLine());

int sum = GetSumNumber(a);
Console.WriteLine($"Сумма чифр в числе = {sum}");
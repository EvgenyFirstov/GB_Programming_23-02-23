/*
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

int GetCountNum(int num)
{
    int count = 0;
    int sourseNum = num;
    while (sourseNum > 0)
    {
        sourseNum = sourseNum / 10;
        count++;
    }
    return count;
}

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int countNum = GetCountNum(num);

Console.WriteLine($"Количество циф в числе = {countNum}");
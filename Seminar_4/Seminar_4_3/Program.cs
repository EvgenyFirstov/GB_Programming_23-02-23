/*
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120
*/

int GetMultiplicationNum(int N)
{
    int result = 1;

    for (int i = 1; i <= N; i++)
    {
        result *= i; // result = result * i;
    }

    return result;
}

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());

int countNum = GetMultiplicationNum(N);

Console.WriteLine(countNum);
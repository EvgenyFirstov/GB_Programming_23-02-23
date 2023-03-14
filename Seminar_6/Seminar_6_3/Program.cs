/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

int IntToBin(int n)
{
    int result = 0;
    int tmpN = 0;

    while (n > 0)
    {
        tmpN = tmpN * 10 + n % 2;
        n /= 2;
    }

    while (tmpN > 0)
    {
        result = result * 10 + tmpN % 10;
        tmpN /= 10;
    }

    return result;
}

Console.Write("Введите число для перевода: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Введенное число в двоичной СС: {IntToBin(n)}");
/*
Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

bool isPalindrome(int number)
{
    int revNumber = 0;
    int sourseNumber = number;

    while (sourseNumber != 0)
    {
        int pop = sourseNumber % 10;
        sourseNumber = sourseNumber / 10;

        // Формирование нового числа (обратное от исходного)
        revNumber = (revNumber * 10) + pop;
    }

    bool isResult = revNumber == number;

    return isResult;
}

Console.Write("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine());

bool result = isPalindrome(number);
Console.WriteLine(result);
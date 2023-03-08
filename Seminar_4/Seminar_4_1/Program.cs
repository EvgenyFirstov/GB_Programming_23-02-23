/* Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/


// Получение суммы чисел в диапазоне от startNumber до endNumber (метод)
int GetSumRange(int startNumber, int endNumber)
{
    int sum = 0;
    for (int i = startNumber; i <= endNumber; i++)
    {
        sum = sum + i; // sum += i;
    }
    return sum;
}

// Запрос исходного числа пользователя
Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine());

int sum = GetSumRange(1, a);
Console.WriteLine(sum);
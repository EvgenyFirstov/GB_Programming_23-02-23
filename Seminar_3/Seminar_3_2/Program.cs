/*
Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
*/

/*
Console.WriteLine("Hello world");

int number = Math.Min(10, 15); // определение минимального числа
Console.WriteLine(number);

int number1 = Math.Abs(101); //взятие по модулю
Console.WriteLine(number1);
*/


// [возвращаемый тип] [имя метода] ([параметры]) {
// }

int GetSum(int a, int b)
{
    int result = a + b;
    return result;
}

int sum = GetSum(10, 15);
Console.WriteLine(sum);
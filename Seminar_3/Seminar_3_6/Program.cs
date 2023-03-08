/*
Задача №22.
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
от 1 до N.

5 -> 1, 4, 9, 16, 25.
2 -> 1,4
*/

/*
int sqr1 = Convert.ToInt32(Math.Pow(sqr1, 2));

Console.Write("Введите число:");
int sqr1 = int.Parse(Console.ReadLine());

for (int i = 1; i <= sqr1; i++) {
    Console.WriteLine($"квадрат {sqr1} = {i*i}");
}
*/

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

for (int i = 1; i <= number; i++)
{
    Console.WriteLine($"Квадрат {i} = {Math.Pow(i, 2)}");
}
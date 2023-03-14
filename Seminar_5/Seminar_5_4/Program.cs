/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/
/*
int GetCountInRange(int[] array, int start, int finish)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (start <= array[i] && array[i] <= finish)
        {
            count++;
        }
    }
    return count;
}

Console.Write("Введите длинну массива: ");
int length = int.Parse(Console.ReadLine());

int[] array = GenerateArray(length);
ShowArray(array);
Console.WriteLine();

Console.Write("Введите начало интервала: ");
int start = int.Parse(Console.ReadLine());

Console.Write("Введите окончание интервала: ");
int finish = int.Parse(Console.ReadLine());

Console.Write("Введите число для поиска: ");
int num = int.Parse(Console.ReadLine());

int countInRange = GetCountInRange(array, start, finish);
Console.Write(countInRange);
*/
/*
void printArray (int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      System.Console.Write(array[i] + " ");
   }
}
int GetCountInRange(int[] array, int start, int finish)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (start <= array[i] && array[i] <= finish)
        {
            count++;
        }
    }
    return count;
}
System.Console.WriteLine("dlina massiva: ");
int Length = int.Parse(Console.ReadLine());
int [] arrray = GenerArray(Length);
printArray(array);
System.Console.WriteLine();
int start = int.Parse(Console.ReadLine());
int finish = int.Parse(Console.ReadLine());
int countInRange = GetCountInRange(array, start, finish);
*/


/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/
/*
void showdualsum (int [] array)
{
    int length = array.Length;
    int halfLength = length/2;
    for (int i = 0; i < halfLength; i++)
    {
        int secondIndex = length - i - 1;
        int sum = array[i] * array[secondIndex];
        System.Console.Write("");
        System.Console.WriteLine($"{sum}");
    }
}
*/
/*
int[] array = new int[10] {1,2,3,4,5,6,7,8,9,10};
for (int i = 0; i < array.Length; i++)
{
    System.Console.WriteLine($"{array[i]} ");
}
int[] array = new int[10] {1,2,3,4,5,6,7,8,9,10};
for (int i = array.Length - 1; i < array.Length; i++)
{
    System.Console.WriteLine($"{array[i]} ");
}
*/
/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

// ПОлучить сумму положит. элементов массива
int GetSumPositiveElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

// ПОлучить сумму отриц. элементов массива
int GetSumNegativeElements(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0)
        {
            sum += array[i];
        }
    }
    return sum;
}

// Вывод массива в консоль
void PrintArrayToConsole(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "");
    }
    Console.WriteLine();
}

//--------------------------------------------------------------------------------------------------

int[] myArray = new int[12]; // { 10, 4, 5, -100, -1000, 5, 4, 3, 2, 4, 1, 10 } - задать данные массива
// Console.WriteLine(myArray.Length); // вывод длинны массива
// Array.Sort(myArray); //Сортировка
for (int i = 0; i < array.Length; i++)
{
    myArray[i] = new Random().Next(-9, 10);
}

// Вывод исходного массива в консоль
PrintArrayToConsole(myArray);

int sumPositiveElements = GetSumPositiveElements(myArray);
int sumNegativeElements = GetSumNegativeElements(myArray);

Console.WriteLine($"Сумма положительных элементов: {sumPositiveElements}");
Console.WriteLine($"Сумма отрицательных элементов: {sumNegativeElements}");
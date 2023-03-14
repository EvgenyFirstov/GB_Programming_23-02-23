/*
Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.
*/

int[] GetCopyArray(int[] array)
{
    int[] tmpArray = new int[array.Length];

    for (int i = 0; i < tmpArray.Length; i++)
    {
        tmpArray[i] = array[i];
    }

    return tmpArray;
}

int[] array = { 1, 5, 3, 8, 3, 9 };
int[] newArray = new int[array.Length];
Array.Copy(array, 0, newArray, 0, 2);

Console.WriteLine($"[{String.Join(", ", newArray)}]");

array[0] = 100;
Console.WriteLine($"[{String.Join(", ", newArray)}]");
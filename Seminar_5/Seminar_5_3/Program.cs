/*
адача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, -3] -> да
*/
/*
void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int[] myarray = new int[12];
for (int i = 0; i < myarray.Length; i++)
{
    myarray[i] = new Random().Next(-9, 10);
}

bool FindElementFromArray(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            return true;
        }
    }
    return false;
}


Console.Write("Введите длинну массива: ");
int length = int.Parse(Console.ReadLine());

int[] array = GenerateArray(num);
ShowArray(array);

Console.WriteLine("");
Console.Write("Введите число для поиска: ");
int num = int.Parse(Console.ReadLine());

bool isPresent = FindElementFromArray(array, num);
ShowArray(array);
Console.WriteLine();
Console.WriteLine(isPresent);
*/

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}
int[] myarray = new int[12];
for (int i = 0; i < myarray.Length; i++)
{
    myarray[i] = new Random().Next(-9, 10);
}
bool FindElem(int[] array, int num)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            return true;
        }
    }
    return false;
}
bool IsPresent = FindElem(array, num);
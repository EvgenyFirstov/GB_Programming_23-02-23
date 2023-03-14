/*
Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
*/
/*
int GeneretArray(int length)
{
    int[] array = new int[length]
    Random myRandom = new Random();

    //Ввод с помошью for
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = myRandom.Next(-9, 10);
    }
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
}
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
void changeArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
}
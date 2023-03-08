/*
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/
/*
void showArray(int[] nums) // void поиск позиции
{
    for (int i = 0; i < nums.Length; i++)
    {
        Console.Write($"{nums[i]}, ");
        countNum++;
    }
}
*/

/*
// бинарный поиск
int GetPositionArray(int num, int[] nums)
{
    int pos1 = 0;
    int pos2 = nums.Length - 1;
    while (pos1 != pos2)
    {
        int midPos = (pos1 + pos2) / 2;
        if (nums[midPos] == num)
        {
            return midPos;
        }
        if (nums[midPos] < num)
        {
            pos1 = midPos;
        }
        else
        {
            pos2 = midPos;
        }
    }
    return -1;
}

int[] nums = new int[8] { 1, 3, 6, 9, 12, 8, 7, 5 };
Array.Sort(nums);

Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());

int position = GetPositionArray(num, nums);
Console.WriteLine(position + 1);
*/
/*
int getPositionArray(int num, int[] nums)
{
    int pos1 = 0;
    int pos2 = nums.Length - 1;
    while (pos1 != pos2)
    {
        int midPos = (pos1 + pos2)/2;
        if (nums[midPos] == num)
        {
            return midPos;
        }
        if(nums[midPos] < num)
        {
           pos1 = midPos;
        }
        else
        {
            pos2 = midPos;
        }
    }

    return -1;
}

int[] nums = new int[8] {1,3,4,5,6,8,9,10};
Array.Sort(nums);
Console.Write("Введите число :");
int num = int.Parse(Console.ReadLine());
int position = getPositionArray(num, nums);
Console.WriteLine(position+1);
*/

void arr(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(0,2);
        index++;
    }
}
void printarr(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        System.Console.Write(array[index]);
        index++;
    }
}
int[] array = new int[8];
arr(array);
printarr(array);
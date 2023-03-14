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

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8 };

void printarray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
    }
}

int serch(int[] arr, int x)
{
    int result = 0;

    for (int i = 0; i < arr.Length; i++)
    {

        if (x == arr[i])
        {
            result = 1;
        }

    }

    return result;
}

Console.Write("vvedite chislo ot 1 do 9: ");
int number = int.Parse(Console.ReadLine());

printarray(array);
int y = serch(array, number);
Console.WriteLine(" " + y);
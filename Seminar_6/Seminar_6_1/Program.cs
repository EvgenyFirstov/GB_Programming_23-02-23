/*
Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
*/

// Создание массива целых чисел
int[] array = new int[5] { 1, 2, 3, 4, 5 };

// Array.Reverse(array);

/*
// Создаем врменный 
int[] tempArray = new int[array.Length];
for (int i = 0; i < array.Length; i++)
{
    tempArray[i] = array[(array.Length - 1) - i];
}
*/

for (int i = 0; i <= (array.Length / 2) - 1; i++)
{
    int temp = array[i];
    array[i] = array[(array.Length - 1) - i];
    array[(array.Length - 1) - i] = temp;
}


Console.WriteLine(array);
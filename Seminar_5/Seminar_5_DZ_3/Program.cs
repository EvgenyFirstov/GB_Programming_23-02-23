/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

double[] doubleArray = new double[20];

for (int i = 0; i < doubleArray.Length; i++)
{
    doubleArray[i] = Math.Round((new Random().NextDouble() * 100), 2);
    Console.Write($"{doubleArray[i]} ");
}

double maxManual = doubleArray[0];
double minManual = doubleArray[0];

double maxAuto = doubleArray.Max();
double minAuto = doubleArray.Max();

for (int i = 0; i < doubleArray.Length; i++)
{
    if (doubleArray[i] > maxManual)
    {
        maxManual = doubleArray[i];
    }

    if (doubleArray[i] < maxManual)
    {
        minManual = doubleArray[i];
    }
}

double result = maxManual - minManual;

Console.WriteLine();
Console.WriteLine($"Разница между max и min = {result}");
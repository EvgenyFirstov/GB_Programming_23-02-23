Console.Write("Введите целое число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите целое число B: ");
int numberB = int.Parse(Console.ReadLine());
int result = (numberA * numberA);
if (result == numberB)
{
    Console.WriteLine("Является квадратом");
}
else
{
    Console.WriteLine("НЕ является квадратом");
}

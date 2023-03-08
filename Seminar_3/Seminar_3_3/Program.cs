/*
Задача №18. Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
*/

/*
int GetP18 (int number)
{
    switch (number)
    {
        case 1:
            Console.Write("x > 0, y > 0");
            break;
        case 2:
            Console.Write("x < 0, y > 0");
            break;
        case 3:
            Console.Write("x < 0, y < 0");
            break;
        case 4:
            Console.Write("x > 0, y > 0");
            break;
        default:
            Console.Write("Входные с ошибкой");
            break;
    }
}

Console.Write("введите номер четверти: ");
int number = int.Parse(Console.ReadLine());
GetP18(number);
*/


Console.Write("введите номер четверти: ");
int number = int.Parse(Console.ReadLine());

switch (number)
    {
    case 1:
        Console.Write("x > 0, y > 0");
        break;
    case 2:
        Console.Write("x > 0, y < 0");
        break;
    case 3:
        Console.Write("x < 0, y < 0");
        break;
    case 4:
        Console.Write("x < 0, y > 0");
        break;
    default:
        Console.Write("Входные с ошибкой");
        break;
    }
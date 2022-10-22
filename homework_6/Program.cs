/*
//Задача 41: 
// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void CountingPositivesNumbers()
{
    int count = 0;
    while (true)
    {
        Console.WriteLine("Please input a number (or a *l* if work is over): ");
        string? InputtingC = Convert.ToString(Console.ReadLine());
        string stop = "l";
        if (InputtingC != stop)
        {
            int n = Convert.ToInt32(InputtingC);
            if (n > 0) count ++;
        }
        else
        {
            Console.WriteLine($"Count of positives numbers is {count}.");
        break;
        }
    }
}
CountingPositivesNumbers();
*/

/*
// Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
Console.Clear();

double FindX (double b1, double b2, double k1, double k2)
{
    if (k1 != k2)
    {
        double x = (b1 - b2) / (k2 - k1);
        return x;
    }
    else return 0;
}

double FindY (double b1, double b2, double k1, double k2)
{
    if (k1 != k2)
    {
        double y = (k2 * b1 - k1 * b2) / (k2 - k1);
        return y;
    }
    else return 0;
}

Console.Write("We are working witn a first straight. ");
Console.WriteLine("Please input a b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please input a k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("We are working witn a second straight. ");
Console.WriteLine("Please input a b1: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Please input a k1: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double resultX = FindX(b1, b2, k1, k2);
double resultY = FindY(b1, b2, k1, k2);

if (resultX == 0 && resultY == 0)
Console.WriteLine("Two straights have no point of intersection");
else
Console.WriteLine($"The point of intersection has a x-coordinate {resultX} and an y-coordinate {resultY}");
*/
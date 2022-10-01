/*
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 == n2)
{
    Console.WriteLine("Your numbers are the same. Please input any other numbers.");
}

else
    if (n1 > n2)
    {
        Console.WriteLine($"Max number is {n1}");
        Console.WriteLine($"Min number is {n2}");
    }
    if (n2 > n1)
    {
        Console.WriteLine($"Max number is {n2}");
        Console.WriteLine($"Min number is {n1}");
    }

*/
/*
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Please input your first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input your second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Please input your third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());
int max = n1;

if (n1 == n2 && n1 > n3) 
{
     Console.WriteLine($"Max numbers are number 1 and number 2");
}
if (n1 == n3 && n1 > n2)
{
     Console.WriteLine($"Max numbers are number 1 and number 3");
}
if (n2 == n3 && n2 > n1)
{
     Console.WriteLine($"Max numbers are number 2 and number 3");
}
if (n1 == n2 && n1 == n3)
{
    Console.WriteLine($"Your numbers are the same. Please input any other numbers.");
}
else 
{
    if (n2 > max)
    {
        max = n2;
    }
    if (n3 > max) 
    {
        max = n3;
    }
    
    Console.WriteLine($"Max number is {max}");
}
*/

/*
// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Please input your number: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0)
{
    Console.WriteLine("Congrats! Your number is even!");
}
else 
{
    Console.WriteLine("Oh no... Your number is not an even number... Try again!");
}
*/

/*
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Please input a number from 1 to infinity: ");
int n = Convert.ToInt32(Console.ReadLine());
int cur = 2;
int max = n;

if (n <= 0)
{
    Console.WriteLine("Your number is uncorrect. Please input another number. Think twice...");
}
if (n == 1)
{
    Console.WriteLine("There are no even numbers in the list. Please input another number again.");
}
if (n > 1)
{
    while (cur <= n)
    
    if (n % 2 == 0)
    {
        Console.Write(cur + " ");
        cur = cur + 2; 
    }
 
    else
    {
        max = max - 1;
        Console.Write(cur + " ");
        cur = cur + 2; 
    }
}
*/
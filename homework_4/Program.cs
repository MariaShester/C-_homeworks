/*
// Задача 25:
// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.Clear();

int Expon(int A, int B)
{
	int result = A;
    int current = 0;
	for (current = 1; current < B; current ++)
	{
		result *= A;
	}
	return result;
}

Console.WriteLine("Input a number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input a number B: ");
int B = Convert.ToInt32(Console.ReadLine());

if (B < 0)
{
    B = B * -1;
}

int result = Expon(A, B);
Console.WriteLine($"The result is {result} ");
*/

/*
// Задача 27:
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Clear();

int SumAllDigits (int num)
{
 int res = 0;
 if (num < 0)
 num = num * -1;
 
 while (num > 0)
    {
        res = res + num % 10;
        num /= 10;
    }
 return res;
}

Console.WriteLine("Please input a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int res = SumAllDigits(num);
Console.WriteLine($"The sum of digits of your number {num} is {res}");
*/

/*
// Задача 29: 
// Напишите программу, которая задаёт массив из m элементов и выводит их на экран.

Console.Clear();

int[] CreateArray (int size)
{
    int[] newArray = new int[size];
    if (size == 0) Console.WriteLine("Uncorrect number. Try again.");
    
    else
    {
        for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next();
        return newArray;
    }
    return newArray;
}   

void ShowArray(int[] newArray)
{
    for(int i = 0; i < newArray.Length; i++)
    
        Console.Write(newArray[i] + " ");

        Console.WriteLine();
    
}

Console.WriteLine("Input an amount of numbers of your future array: ");
int size = Convert.ToInt32(Console.ReadLine());

if (size < 0) size = size * -1;

int[] resultEnd = CreateArray(size);
ShowArray(resultEnd);
*/
/*
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
Console.Clear();

int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    Console.WriteLine("Creating a new array:");
        for (int i = 0; i < size; i ++)
        newArray[i] = new Random().Next(100, 999 + 1);
        return newArray;
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i ++)
    Console.Write(array[i] + " ");
}

int Count(int[] array)
{
    int res = 0;
    for(int i = 0; i < array.Length; i ++)
    {
        if(array[i] % 2 == 0) res ++;
    }
    return res;
}

Console.WriteLine("Please input a count of numbers in your future array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] resultA = CreateArray(size);
ShowArray(resultA);
Console.WriteLine();
int count = Count(resultA);
Console.WriteLine($"Count of even numbers in your array is {count}");
*/
/*
// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

int[] CreateArray(int size)
{
    int[] array = new int[size];
    Console.WriteLine("Creating a new array:");
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(); 
    }
    Console.WriteLine("Complete!");
    return array;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i ++)
    Console.WriteLine(array[i] + " ");
    Console.WriteLine();
}

int SumOfOddNumbers(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 != 0 )
        sum += array[i];   
    }
    return sum;
}

Console.Write("Input a number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
int result = SumOfOddNumbers(myArray);

ShowArray(myArray);
Console.WriteLine("Sum of numbers from all odd-numbers position is " + result);
*/
/*
// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

double[] CreateArray(int size)
{
    double [] newArray = new double[size];
    Console.WriteLine("Creating a new array:");
    for (int i = 0; i < size; i ++)
        newArray[i] = new Random().Next();
    return newArray;
}

void ShowArray(double[] array)
{
    for(int i = 0; i < array.Length; i ++)
    Console.Write(array[i] + " ");
}

double Subtraction(double[] array)
{
    double min = array[0];
    double max = array[0];

    for (int i = 1; i < array.Length; i ++)
    {
        if (array[i] < min) min = array[i];
        else if (array[i] > max) max = array[i];
    }
    return max - min;
}

Console.WriteLine("Please input a count of numbers in your future array: ");
int size = Convert.ToInt32(Console.ReadLine());

double[] ourArray = CreateArray(size);
ShowArray(ourArray);
Console.WriteLine();
double result = Subtraction(ourArray);
Console.WriteLine($"The difference between max and min number is {result}");
*/
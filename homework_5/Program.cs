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
int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(1, 10);
    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}
void FindElectedElement(int[,] array)
{
    Console.WriteLine("Input a row* index of your number: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a column* index of your number: ");
    int j = Convert.ToInt32(Console.ReadLine());

    if ((i >= 0 && i < array.GetLength(0)) && (j >= 0 && j < array.GetLength(1)))
    Console.WriteLine($"There is the number with your indexes [{i}], [{j}] - {array[i, j]}");
    else
    Console.WriteLine($"The number with your indexes does not exist. Maybe we can find it beyond the created array...");
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
FindElectedElement(myArray);
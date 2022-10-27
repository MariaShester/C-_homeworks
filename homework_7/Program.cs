/*
// Задача 47. 
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int n = Convert.ToInt32(Console.ReadLine());
    
    double [,] array = new double [m,n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
        {
             array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
            
    return array;
}

void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}

double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/
/*
// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
Console.Clear();
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
    int ix = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Input a column* index of your number: ");
    int jx = Convert.ToInt32(Console.ReadLine());

    if ((ix >= 0 && ix < array.GetLength(0)) && (jx >= 0 && jx < array.GetLength(1)))
    Console.WriteLine($"There is the number with your indexes [{ix}], [{jx}] - {array[ix, jx]}");
    else
    Console.WriteLine($"The number with your indexes does not exist. Maybe we can find it beyond the created array...");
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
FindElectedElement(myArray);
*/
/*
// Задача 52.
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Console.Clear();

int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next();
    return array;
}

double[] ResultSumArray (int[,] array)
{
    double[] newArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
            sum += array[i, j];
            newArray[j] = Math.Round((sum / array.GetLength(0)), 1);
    }
    return newArray;
}

void ShowFirstArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
            Console.WriteLine();
    }
}        

void ShowLastArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

int[,] myArray = CreateRandom2dArray();
ShowFirstArray(myArray);
double[] newArray = ResultSumArray(myArray);
ShowLastArray(newArray);
*/

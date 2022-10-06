/*
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Please input a triple-digits: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 99 && number < 1000) 
{
   int numberBetter = number / 10;
   int numberBest = numberBetter % 10;
   Console.WriteLine($"Second digit is {numberBest}");
}
if (number < -99 && number > -1000)
{
   int numberBetter = number / 10;
   int numberBest = numberBetter % 10 * -1;
   Console.WriteLine($"Second digit is {numberBest}");
}
else
    Console.WriteLine($"Your number is uncorrect. Please input a triple-digits.");
*/

// Второе решение

/*
Console.Clear();

int FindSecondNumber(int userNumber)
    
    {
     int result;
     if (userNumber > 99 && userNumber < 1000)
      {
        result = userNumber / 10 % 10;
        return result;
      }
     if (userNumber > -1000 && userNumber < -99)
      {
        result = userNumber / 10 % 10 * -1;
        return result;
      }
     else 
      {
        Console.WriteLine("This is not a triple-digits number.");
        result = 0;
        return result;
      }
    }
Console.WriteLine("Please input a triple-digits: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int newNumber = FindSecondNumber(userNumber);
Console.WriteLine($"Second digit of {userNumber} is {newNumber}");
*/

/*
// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Clear();

int ShowThirdDigit(int userNumber)
{ 
    if (userNumber > 99 && userNumber < 1000)
    {
        int result;
        result = userNumber % 10;
        Console.WriteLine($"Third digit of your number {userNumber} is {result}");
        return result;
    }
    if (userNumber < -100 && userNumber > -999)
    {
        int result;
        result = userNumber % 10 * -1;
        Console.WriteLine($"Third digit of your number {userNumber} is {result}");
        return result;
    }
    if (userNumber < 99 && userNumber > -99)
    {
        int result;
        result = -0;
        Console.WriteLine($"There is no third digit in the number {userNumber}"); 
        return result;
    }
    if (userNumber > 999 && userNumber < 10000)
    {
        int result;
        result = userNumber / 10 % 10;
        Console.WriteLine($"Third digit of your number {userNumber} is {result}");
        return result;
    }
    if (userNumber < -999 && userNumber > -10000)
    {
        int result;
        result = (userNumber / 10 % 10) * -1;
        Console.WriteLine($"Third digit of your number {userNumber} is {result}");
        return result;
    }
    else // for numbers under 10000
    {
        int result;
        result = userNumber % 1000 / 100;
        Console.WriteLine($"Third digit of your number {userNumber} is {result}");
        return result;
    }
}

Console.WriteLine("Please input a number: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
int result = ShowThirdDigit(userNumber); 
*/

/*
// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Clear();

string IdentifyDay(int number)
{
    if (number >= 1 && number <=5)
    {
        string result;
        result = "work";
        Console.WriteLine($"This day is for {result}");  
        return result;
    }
    if (number >= 6 && number <= 7)
       {
        string result;
        result = "relax. It is a day-off.";
        Console.WriteLine($"This day is for {result}");  
        return result;
       } 
    else
       {
        string result;
        result = "Try again.";
        Console.WriteLine($"There are seven days per week. {result}");  
        return result;
       }
}

Console.WriteLine("Please input a day`s number: ");
int number = Convert.ToInt32(Console.ReadLine());
string result = IdentifyDay(number);
*/
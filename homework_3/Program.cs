/*
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Input a five-digits number: ");
int N = Convert.ToInt32(Console.ReadLine());

int firstDigit = 0;
int lastDigit = 0;
int secN = 0;
int secDigit = 0;
int beforeLastDigit = 0;

if (N < 10000 || N >= 100000)
    Console.WriteLine($"Число {N} не является пятизначным");
if (N > 9999 && N <= 99999 )
   {
     firstDigit = N / 10000;
     lastDigit = N % 10;
     if (firstDigit == lastDigit)
        {
           secN = N % 10000 / 10;
           secDigit = secN / 100;
           beforeLastDigit = secN % 10;
           Console.WriteLine($"Число {N} является палиндромом");
        }
   
     else 
            Console.WriteLine($"Число {N} не является палиндромом");
   }
 */

/*
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

double DistanceBetween (double xA, double yA, double zA, double xB, double yB, double zB)
{
   double distance = Math.Round(Math.Sqrt(Math.Pow(xB - xA, 2) + Math.Pow(yB - yA, 2) + Math.Pow(zB - zA, 2)), 2);
   return distance;
}

Console.WriteLine("Input an A x-coordinate: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input an A y-coordinate: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input an A z-coordinate: ");
double zA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input a B x-coordinate: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input a B y-coordinate: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Input a B z-coordinate: ");
double zB = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"Distance between points A({xA}, {yA}, {zA}) and B({xB}, {yB}, {zB}) is {DistanceBetween(xA, xB, yA, yB, zA, zB)} ");
*/

/*
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void FindAllCubes (int N)
{
   int cur = 1;
   int b = 3;
   while (cur <= N)
   {
      Console.WriteLine(Math.Pow(cur, b));
      cur ++;
   }
}

Console.Write("Input your number > 0: ");
int N = Convert.ToInt32(Console.ReadLine());
FindAllCubes (N);

if (N <= 0)
{
   Console.Write($"Your number {N} is uncorrect.");
}
*/
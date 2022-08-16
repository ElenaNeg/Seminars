/*
//Задача 1. Необходимо написать программу которая принимает на вход координаты точки(x,y), причем точки должны быть не нулевыми и выдает номер четверти в каторой находится эта точка.

int FindQuart(double x, double y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;

    return 0;
}
Console.Write("Input first number: ");
double xA = Convert.ToInt32(Console.ReadLine());
Console.Write("Input second number: ");
double yA = Convert.ToInt32(Console.ReadLine());

int quartNum = FindQuart(xA, yA);

if(quartNum == 0)
{
    Console.Write("Point on the axes!");
}
else
{
    Console.Write($"Point is located on {quartNum} quart");
}
*/
/*
//Задача 2. Нужно написать программу, которая по заданному номеру четверти показывает диапазон возможных координат точек. (обратная задача).
void FindCooardinats (int quart)
{
    if(quart == 1)
        Console.WriteLine("Диапазон (x+, y+)");
    if(quart == 2)
        Console.WriteLine("Диапазон (x-, y+)");
    if(quart == 3)
        Console.WriteLine("Диапазон (x-, y-)");
    if(quart == 4)
        Console.WriteLine("Диапазон (x+, y-)");
    if(quart > 4 || quart < 1)
        Console.WriteLine("Диапазон не существует");
}
Console.Write("Input number of quart: ");
int quart = Convert.ToInt32(Console.ReadLine());
FindCooardinats(quart);
*/
/*
//Задача 3. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

double FindDistance (double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2));
    
}
Console.Write("Input x1: ");
double xa = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y1: ");
double ya = Convert.ToDouble(Console.ReadLine());
Console.Write("Input x2: ");
double xb = Convert.ToDouble(Console.ReadLine());
Console.Write("Input y2: ");
double yb = Convert.ToDouble(Console.ReadLine());

double coordinate = FindDistance(xa, ya, xb, yb);
Console.WriteLine($"Distance is {coordinate}");
*/
/*
//Задача 4. Необходимость написать программу, которая принимает на вход некоторое число {N} и выдает на консоль квадраты чисел от 1 до N.  

void ShowSquare(int n)
{
    int current = 1;
    while (current <= n)
    {
        Console.WriteLine($"Квадрат числа {current} = {current * current}:");
        current++;
    }
}
Console.Write("Введите любое целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowSquare(number);
*/

/*
int num = 5;
Console.WriteLine("My number is " + num);
*/
/*
int num;

Console.Write("Input a number: ");
num = Convert.ToInt32(Console.ReadLine());
Console.Write("Your number is " + num);
*/
// Задача 1. На вход получить число, и найти его квадрат 

Console.Write("Input a number: ");
int num = Convert.ToInt32(Console.ReadLine());

int quad = num * num;

Console.Write("The quadrate of " + num + " is " + quad);
Console.Write($"The quadrate of {num} is {quad}");
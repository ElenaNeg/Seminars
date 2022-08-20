/*
//Задача 1. найти сумму от 1 до а.

int FindSum(int number)
{
    int sum = 0;
    for(int current = 1; current <= number; current++)
    {
        sum = sum + current;    //sum +=current;
    }
    return sum;
}
Console.WriteLine("Input integer number ");
int a = Convert.ToInt32(Console.ReadLine());

//int result = FindSum(a);
//Console.WriteLine($"Sum of numbers from 1 to {a} is {result}");
Console.WriteLine($"Sum of numbers from 1 to {a} is {FindSum(a)}");
*/
/*
//Задача 1. Необходино написать программу, которая принимает на вход число 
//и выдает колличество цифр в числе.

int FinDidgits (int number)
{
    int current = 0;
    while (number > 0)
    {
        number = number / 10;
        current++;
    }
    return current;
}
Console.Write("Введите число ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Количество цифр в числе {a} = {FinDidgits(a)}");
*/

/*
//Задача 2. Написать программу которая принимает число N и выдает произведение от 1 до N.

int FindMult(int number)
{
    int factorial = 1;
    for(int current = 1; current <= number; current++)
    {
        factorial = factorial * current;    
    }
    return factorial;
}
Console.WriteLine("Input integer number ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Multiplication of numbers from 1 to {num} is {FindMult(num)}");
*/
/*
//Задача 3. Необходимо написать программу которая выводит массив из 8 элементов заполненный 0 и 1 в произвольной форме.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue +1);

    return newArray;   
}

void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine ();
}

Console.WriteLine("Input size for array ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min possible value fo element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input mmax possible value fo element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
*/
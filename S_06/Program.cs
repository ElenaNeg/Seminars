// Задача 1 Написать программу, которая перевернет одномерный массив (последний элемент 
// будет на месте первого, предпоследний на месте втором и т.д...)

// int[] ReverseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {       
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
//     return array;
// }
/*
int[] ReverseArray(int[] array)
{
    for (int i = 0, j = array.Length - 1; i < j; i++, j--)
    {       
        int temp = array[i];
        array[i] = array[j];
        array[j] = temp;
    }
    return array;
}
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int [size];
    for (int i=0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

        return newArray;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine ();
}

Console.WriteLine("Input size for array ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min value fo element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max value fo element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);
ShowArray(ReverseArray(myArray));
*/

//Задача2 Необходимо написать программу которая принимает на вход три числа и проверяет
// может ли существовать треугольник со сторонами такой длинны. (каждая сторона треугольника,
// должна быть меньше сум этих сторон a < b + c).
/*
bool CheckTriangle(int a, int b, int c)
{
    if ((a + b > c) && (a + c > b) && (b + c > a)) return true;
    else return false;
}
Console.WriteLine("Input first length: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second length: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input third length: ");
int z = Convert.ToInt32(Console.ReadLine());
bool result = CheckTriangle(x, y, z);
if (result == true) Console.WriteLine($"trangle with sides: {x}, {y}, {z} exists");
else Console.WriteLine($"trangle with sides: {x}, {y}, {z} does not exist"); 
*/
/*
//Задача 3. необходимо не используя рекурсию вывести первое число фибоначи первые два числа 
// фибоначи a и  b.

int[] Fibbonachi(int firstNumber, int secondNumber, int size)
{
    int[] array = new int [size];
    array[0] = firstNumber;
    array[1] = secondNumber;
    for(int i=2; i < size; i++)
    {
        array[i] =  array[i - 2]+ array[i - 1];
    }
    return array;
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    
    Console.WriteLine ();
}
Console.WriteLine("Input first number: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input size number: ");
int z = Convert.ToInt32(Console.ReadLine());

ShowArray(Fibbonachi(x, y, z));
*/
/*
// Задача 4. необходимо написать программу которая будет преобразовывать десятичное число в 
// двоичное.

void DecimalToBinary (int number)
{
    string result = string.Empty;
    while (number > 0)
    {
        result = number % 2 + result;
        number /=2;
    }
    Console.WriteLine(result);
}
Console.WriteLine("Input decimal number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Number {num} to binuty is ");
DecimalToBinary(num);
*/
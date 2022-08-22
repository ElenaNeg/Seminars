// Задача1 Напишите программу, Необходимо заполнить массив из 12 элементов. 
// Заполнить массив случайными числами из промежутка из -9 до 9.
// И найти сумму отрицательных элементов и сумму всех положительных элементов.
/*
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

void FindMinMax(int[] array)
{
    int sumPositive = 0;
    int sumNegative = 0;

    for(int i = 0; i<array.Length; i++)
    {
        if(array[i] > 0)
            sumPositive +=array[i];
        else
            sumNegative +=array[i];
    }

    Console.WriteLine("sum of negative elements is " + sumNegative);
    Console.WriteLine("sum of positive elements is " + sumPositive);
}

Console.WriteLine("Input size for array ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min possible value fo element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max possible value fo element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
FindMinMax(myArray);
*/

// Задача 2 Написать программу замены элементов массива. Положительные элементы заменить 
// на отрицательные и наоборот.
/*
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

int[] ChangeElements(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * (-1);
    }
    return array;       
}

Console.WriteLine("Input size for array ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min possible value fo element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input max possible value fo element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
ShowArray(ChangeElements(myArray));
*/
/*
// Задача 3 Необходимо задать массив и написать программу, которая определяет  
// присутствует ли заданное число в массиве.

int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input [i] element of the array: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;   
}
void ShowArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
        Console.Write(array[i] + ",");
    Console.WriteLine ();
}

bool CheckNumber(int[] array, int n)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == n) return true; // return if (arrai[i] == n);      
    }
    return false;   
}

Console.Write("Input size for array: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Input integer number: ");
int number = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateArray (a);
ShowArray(myArray);
bool check = CheckNumber(myArray, number);
if (check == true) Console.WriteLine($"Number {number} found in array");
else Console.WriteLine($"Number {number} not found in the array");
*/
/*
// Задача 4 Задать одномерный массив из 12 элементов, случайных чисел. Необходимо найти 
// колличество элементов, которые лежат в отрезку от 10 до 99.

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

int CountElements(int[] array, int min, int max)
{
    int count = 0;
    
    for(int i = 0; i<array.Length; i++)
    {
        if(array[i] >= min && array[i] <= max) count++;     
    }
    return count;
}

Console.WriteLine("Input size for array ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min possible value fo element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input mmax possible value fo element: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min value : ");
int min1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input max value: ");
int max1 = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
int result = CountElements(myArray, min1, max1);
Console.WriteLine($"колличество элементов массива, находиться в заданном отрезке равно {result}");
*/ 
/*
//Задача 5. необходимо найти произведение пар чисел в одномерном массиве.  
// парами считаем первый и последний элемент, 2 и предпоследний.

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

int[] CompositionPairsofElements(int[] array)
{
    int[] newArray = new int [array.Length / 2];
    
    for(int i = 0; i < array.Length / 2; i++)
    {
         newArray[i] = array[i] * array[array.Length - 1 - i];     
    }
    return newArray;
}

Console.WriteLine("Input size for array ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input min possible value fo element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input mmax possible value fo element: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
ShowArray(CompositionPairsofElements(myArray));
*/
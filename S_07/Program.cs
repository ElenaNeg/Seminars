/*
// Задача 1 Необходимо написать программу которая задаст двумерный массив размером N на N заполненный случайными числами.

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);                
    
    return newArray;
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] +" ");
            
        Console.WriteLine();
    }
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colomns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandom2DArray(m, n, min, max);
Show2DArray(myArray);
*/
/*
//Задача 2 Задать двумерный массив n*n. Каждый элемент в массиве которого находиться по формуле а(i, j) = i+j.

int[,] To2DArray(int rows, int columns)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i, j] = i+j;                
    
    return newArray;
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] +" ");
            
        Console.WriteLine();
    }
}
Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colomns: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = To2DArray(m, n);
Show2DArray(myArray);
*/
/*
// Задача 3. Необходимо задать двумерный массив. Найти элементы у которых оба индекса четные и заменить эти элементы на их квадраты.(берем на вход массив и его возвращает)

int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i, j] = i+j;                
    
    return newArray;
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] +" ");
            
        Console.WriteLine();
    }
}

int[,] ChengeElementsofArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i+=2)
        for(int j = 0; j < array.GetLength(1); j+=2)
            array[i, j] = array[i, j] * array[i, j];
    
    return array;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colomns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArray(m, n, min, max);
Show2DArray(myArray);
ChengeElementsofArray(myArray);
Console.WriteLine();
Show2DArray(myArray);
*/
/*
// Задача 4. Необходимо задать двумерный массив. И найти сумму элементов главной диагонали.(т.е i=j)

int[,] Create2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for(int i = 0; i < rows; i++)
        for(int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);                
    
    return newArray;
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] +" ");
            
        Console.WriteLine();
    }
}

int SumElementsofArray(int [,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        sum = sum + array[i, i];
    }
        
    
    return sum;
}

Console.Write("Input number of rows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number of colomns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min possible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max possible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArray(m, n, min, max);
Show2DArray(myArray);
int sum = SumElementsofArray(myArray);
Console.WriteLine ($"Sum elements of array of main diagonale is {sum}");
*/

/*
//Задача 1. Необходимо задать двухмерный массив и написать программу которая поменяет местами 
// первую и последнюю строку местами.реализуем любую строку с любой

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
    Console.WriteLine();
}

int[,] ChangeRows(int[,] array, int row1, int row2)
{
    if(row1 >= array.GetLength(0) || row2 >= array.GetLength(0))
    {
        return array;
    }
    else 
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
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

int[,] myArray = CreateRandom2DArray(m, n, min, max);
Show2DArray(myArray);
myArray = ChangeRows(myArray, 0 , m-1);
Show2DArray(myArray);
*/

/*
//Задача 2 Задайте двумерный массив и напишите программу которая меняет строки на столбцы.
// Если это не возможно то программа должна вывести об этом. ([i, j] поменять местами [j, i])

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ChangeRowsColomns(int[,] array)
{
    if (array.GetLength(0) == array.GetLength(1))    
    {
        for (int i = 0; i < array.GetLength(0)-1; i++)
            for (int j = i + 1; j < array.GetLength(1); j++)
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
    }
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

    int[,] myArray = CreateRandom2DArray(m, n, min, max);
    Show2DArray(myArray);
    ChangeRowsColomns(myArray);
    Show2DArray(myArray);
*/

//Задача 3 Из двумерного массива целых чисел, удалить строку и столбец на пересечении 
// которых расположен минимальный элемент. (два варианта создать новый массив или заполнить ноликами )

int[,] CreateRandom2DArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] DeleteRowsColomns(int[,] array)
{
    int min = array[0,0],
        t1 = 0,  //i
        t2 = 0;  //j
    //int [,] newArray = new int [array.GetLength(0), array.GetLength(1)]
     for (int i = 0; i < array.GetLength(0); i++)
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i,j] < min)
                {
                    min = array[i,j];
                    t1 = i;
                    t2 = j;
                }
            }
    for(int i = 0; i < array.GetLength(0); i++) 
        array[i, t2] = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        array[t1, j] = 0;

    Console.WriteLine (t1 + "" + t2 + "" + min);

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

    int[,] myArray = CreateRandom2DArray(m, n, min, max);
    Show2DArray(myArray);
    DeleteRowsColomns(myArray);
    Show2DArray(myArray);

// Задача 4 
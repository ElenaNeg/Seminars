﻿
//Задача 1 Найти максимальное из 9 чисел.
/*
int a1 = 15;
int b1 = 21;
int c1 = 39;
int a2 = 12;
int b2 = 2331;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33;

int max = a1;
if (b1 > max) max = b1;
if (c1 > max) max = c1;

if (a2 > max) max = a2;
if (b2 > max) max = b2;
if (c2 > max) max = c2;

if (a3 > max) max = a3;
if (b3 > max) max = b3;
if (c3 > max) max = c3;

Console.WriteLine(max);
*/
//Второй вариант решения задачи - упращенный.
/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
int a1 = 15;
int b1 = 23421;
int c1 = 39;
int a2 = 12;
int b2 = 2331;
int c2 = 33;
int a3 = 13;
int b3 = 23;
int c3 = 33;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max = Max(max1, max2, max3);
// Можно закомментированные строки выше заменить на :
int max = Max(Max(a1, b1, c1), Max(a2, b2, c2), Max(a3, b3, c3));

Console.WriteLine(max);
*/

// Задача 2. Попробуем избавится от множества переменных использую для этого массив.
/*
int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//            0  1  2   3  4  5  6  7  8
int[] array = {11,211,31,41,15,61,17,18,19};

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8]));

Console.WriteLine(max);
*/

//Задача 3 для любого колличеста элементов массива.
/*
int[] array = {1, 12, 31, 4, 15, 16, 17, 18};
int n = array.Length;
int find = 18;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    //index = index + 1; 
    index++;
}
*/
//Запишем 2 вариант полее лучше.
/*
int[] array = {1, 12, 31, 4, 18, 15, 16, 17, 18};
int n = array.Length;
int find = 18;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    //index = index + 1; 
    index++;
}
*/
//Создаем задачку, чтобы массив сам определял свою длину. 
void FillArray(int[] collection);
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        Collection[index] = new Random().Next(1, 10);
        //index = index + 1;
        index++;
    }
}


//int[] array = new int[10];

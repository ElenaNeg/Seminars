//Рекурссии :)
// Задача 1. Задать значение N и написать программу которая выведит все натуральные числа в промежутке от 1 до N
/*
void ShowNumbers(int n)
{
    //обязательно прописывать до которого момента мы будим вызывать наш метод!
    if(n > 1) ShowNumbers(n - 1); // условие существования рекурсси
    
    Console.Write(n + " ");
}

ShowNumbers(10);
*/
/*
// Задача 2. Написать программу которая на вход будет принимать число и возвращать сумму цифр.

void ShowNumbers(int n)
{
    if(n > 1) ShowNumbers(n - 1); 
    
    Console.Write(n + " ");
}

int FindSum(int n)
{
    if(n > 0)
  
        return FindSum(n / 10) + n % 10;
  
    else 
        return n; 
}

// 123
ShowNumbers(10);
Console.WriteLine();
Console.WriteLine(FindSum(12345));
*/

// Задача3. задать значение m * n, и написать программу которая выведет все натуральные числа 
// в промежутке от n до m
/*
void ShowNumbers(int n, int m)
{
    if(m != n)
    {
        if(n > m) 
        {
            ShowNumbers(n - 1, m);
            Console.Write(n + " ");
        }         
        else
       {
            ShowNumbers(m - 1, n);
            Console.Write(m + " ");
       }
    }
    else
    Console.Write(m +" ");
}
ShowNumbers(5,10);
*/
/*
// Задача4. необходимо написать программу которая принимает два числа A и B, и возводит
// A в целую степень B с помощью рекурсии.

int NumberPower(int a, int b)
{
    if (b!=0)
        return NumberPower(a, b-1)* a;
    else return 1;    
}

Console.WriteLine(NumberPower(2, 3));
*/
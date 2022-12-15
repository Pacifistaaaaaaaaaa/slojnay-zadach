﻿Console.WriteLine("введите номер строки");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите номер столбца");
int b = Convert.ToInt32(Console.ReadLine());
int [,] numbers = new int [5,10];
RandomNumbers(numbers);

if (a > numbers.GetLength(0) || b > numbers.GetLength(1))
{
    Console.WriteLine("такого элемента нет");
}
else
{

    Console.WriteLine (numbers[a-1,b-1]);

}


PrintArray(numbers);

void RandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(1, 10);
            }   
        }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }   
        Console.Write("]");
        Console.WriteLine(""); 
    }
}
﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.WriteLine("Введите количество строк");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int j = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[i,j];
FillArray(array);
PrintArray(array);


void FillArray(double[,] array)
{
    for(int i = 0; i<array.GetLength(0);i++)
        for(int j = 0; j<array.GetLength(1);j++)
            array[i,j] = Math.Round((100 + new Random().NextDouble() * 300),2);
}

void PrintArray(double[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
        {
        for (int j=0;j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],3} \t");
        Console.WriteLine();
        }
}
﻿// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Количество чётных элементов массива равна {Count(array)}");

void FillArray(int[] array)
{
    for(int i = 0;i<array.Length; i++)
    {
        array[i]=new Random().Next(100,1000);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0;i<array.Length;i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine("");
}

int Count(int[] array)
{
    int count = 0;
    for(int i = 0;i<array.Length; i++)
    {
        if(array[i]%2==0)
            count++;
    } 
    return count;
}
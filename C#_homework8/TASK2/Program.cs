// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Введите количество строк");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int j = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[i,j];
int[] sums = new int[i];
FillArray(array);
PrintArray(array);
Sum(array,sums);
Console.WriteLine();
MinPosition(sums);


void Sum (int[,] array, int[] sums)
{
    int x = 0;
    while(x<array.GetLength(1))
    {
        for (int i=0;i<array.GetLength(0);i++)
            sums[i]+=array[i,x];
        x++;
    }
}

void PrintArray(int[,] array)
{
    for (int i=0;i<array.GetLength(0);i++)
        {
        for (int j=0;j<array.GetLength(1);j++)
            Console.Write($"{array[i,j],3} \t");
        Console.WriteLine();
        }
}

void FillArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0);i++)
        for(int j = 0; j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(0,11);
}

void MinPosition(int[] array)
{
    int min = array[0];
    int minIndex = 0;
    for(int i = 0;i<array.Length;i++)
    {
        if(min>array[i])
        {
            min = array[i];
            minIndex = i;
        }
    }
    Console.WriteLine($"Наименьшая сумма элементов в {minIndex+1} строке массива");
}


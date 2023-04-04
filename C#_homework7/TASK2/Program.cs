// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

Console.WriteLine("Введите количество строк");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int j = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое число");
int f = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[i,j];
int[] index = {-1,-1};
FillArray(array);
PrintArray(array);
Console.WriteLine();
Find(array,f,index);
if(index[0]>-1 && index[1]>-1)
{
    Console.WriteLine($"Число {f} находится в массиве под индексами [{index[0]},{index[1]}]");
}
else
Console.WriteLine($"Число {f} в массиве отсутствует");



void FillArray(int[,] array)
{
    for(int i = 0; i<array.GetLength(0);i++)
        for(int j = 0; j<array.GetLength(1);j++)
            array[i,j] = new Random().Next(0,11);
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

void Find(int[,] array, int f, int[] index)
{
    for(int i = 0; i<array.GetLength(0);i++)
        for(int j = 0; j<array.GetLength(1);j++)
        {
            if(array[i,j] == f)
            {
                index[0] = i;
                index[1] = j;
                break;
            } 
        }        
}


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18




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

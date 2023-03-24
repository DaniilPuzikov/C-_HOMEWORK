// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    for(int i = 0; i<8; i++)
    {
        array[i] = new Random().Next(0,10);
    }
}

void PrintArray(int[] array)
{
    Console.Write($"[{array[0]}, ");
    for (int i = 1; i<array.Length-1;i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}]");
}
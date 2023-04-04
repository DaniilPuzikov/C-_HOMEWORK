// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.

// Например, задан массив:
// 1 4 7 2
// 5 9 10 3

// После сортировки
// 1 2 3 4
// 5 7 9 10

Console.WriteLine("Введите количество строк");
int i = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int j = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[i,j];
int[] oneline = new int[i*j]; 
FillArray(array);
PrintArray(array);
ToOneLineArray(array,oneline);
PrintArrayOneLine(oneline);



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

void ToOneLineArray(int[,] array1, int[] array2)
{
    for(int i = 0; i<array1.GetLength(0);i++)   
        for(int j = 0; j<array1.GetLength(1);j++)
            for(int x = 0; x<array2.Length;x++)
                array2[x] = array1[i,j];
}

void PrintArrayOneLine(int[] array)
{
    for(int x = 0; x<array.Length;x++)
        Console.Write($"{array[x]} ");
    Console.WriteLine();
}
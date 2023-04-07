// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


int[,] array = new int[5,5];
FillArray(array);
PrintArray(array);
int[] temp1 = new int[5];
int[] temp2 = new int[5];
int[] temp3 = new int[5];
int[] temp4 = new int[5];
int[] temp5 = new int[5];
//В условии не говорится, что размер массива задаётся пользователем
Answer(temp1,temp2,temp3,temp4,temp5);


void SortLine(int[] array)
{
    Array.Sort(array);
    Array.Reverse(array);
}
void FillLine(int[,] array, int[] temp, int index)
{
    for(int i = 0;i<5;i++)
    {
        temp[i] = array[index,i];
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

void PrintLine(int[] array)
{
    for(int i = 0;i<array.Length;i++) 
        Console.Write($"{array[i],3} \t");
    Console.WriteLine();
}
void Answer(int[] temp1,int[] temp2, int[] temp3, int[] temp4, int[] temp5)
{
FillLine(array,temp1,0);
SortLine(temp1);
FillLine(array,temp2,1);
SortLine(temp2);
FillLine(array,temp3,2);
SortLine(temp3);
FillLine(array,temp4,3);
SortLine(temp4);
FillLine(array,temp5,4);
SortLine(temp5);
Console.WriteLine();
Console.WriteLine("После сортировки");
Console.WriteLine();
PrintLine(temp1);
PrintLine(temp2);
PrintLine(temp3);
PrintLine(temp4);
PrintLine(temp5);
}


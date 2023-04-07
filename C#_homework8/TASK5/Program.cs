// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = new int[4,4];
//Задача требует заполнение массива 4x4
Spiral(array);
PrintArray(array);


void Spiral(int[,] array)
{
    int helper = 0;
    for(int i = 0;i<4;i++)
        array[0,i] = i+1;
    for(int j = 0;j<4;j++)
        array[j,3] = j+4;
    for(int x = 0; x<3;x++)
        array[3,x] = 10-x;
    for(int y = 3; y>0;y--)
    {
        array[y,0]=10+helper;
        helper++;
    }
    helper = 0;
    for(int z = 1;z<3;z++)
        array[1,z] = 12+z;
    for(int t = 2;t>0;t--)
    {
        array[2,t] = 15+helper;
        helper++;
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
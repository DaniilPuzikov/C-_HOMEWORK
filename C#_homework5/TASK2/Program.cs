// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
FillArray(array);
PrintArray(array);
Console.WriteLine($"Сумма всех элементов массива на нечётных позициях равна {Summa(array)}");


void FillArray(int[] array)
{
    for(int i = 0;i<array.Length; i++)
    {
        array[i]=new Random().Next(1,41);
    }
}

void PrintArray(int[] array)
{
    for(int i = 0;i<array.Length;i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine("");
}

int Summa(int[] array)
{
    int sum = 0;
    for(int i = 0; i<array.Length; i++)
    {
        if(i%2!=0)
        {
            sum+=array[i];
        }
    }
    return sum;
} 
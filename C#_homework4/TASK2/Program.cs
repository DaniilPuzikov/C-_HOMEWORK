// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int size = Size(a);
int[] array = new int[size];
FillArray(a, size);
Console.WriteLine($"Сумма цифр в числе равна {Sum(array)}");

int Size(int a)
{
    int size = 0;
    while(a>0)
    {
        a/=10;
        size++;
    }
    return size;
}

void FillArray(int a, int size)
{
    for (int i = 0; i<size; i++)
    {
        array[i]=a%10;
        a/=10;
    }
}

int Sum(int[] array)
{
    int sum = 0;
    for (int i = 0; i<array.Length; i++)
    {
        sum+=array[i];
    }
    return sum;
}


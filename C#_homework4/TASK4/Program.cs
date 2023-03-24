// Задача 27 HARD: Напишите программу, которая принимает на вход число (целое, вещественное, в экспоненциальной форме) и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9,012 -> 12

// 6,02214129e23 -> 27 

double a = Convert.ToDouble(Console.ReadLine());
long b = MakeLong(a);
int size = Size(b);
long[] array = new long[size];
FillArray(array, b);
Console.WriteLine($"Сумма цифр в числе равнa {Sum(array)}");

long MakeLong(double a)
{
    while(a%1!=0)
        a*=10;
    return Convert.ToInt64(a);
}

int Size(long a)
{
    int size = 0;
    while(a>0)
    {
        a/=10;
        size++;
    }
    return size;
}

void FillArray(long[] array, long a)
{
    for (int i = 0; i<array.Length; i++)
    {
        array[i]=a%10;
        a/=10;
    }
}

long Sum(long[] array)
{
    long sum = 0;
    for (int i = 0; i<array.Length; i++)
    {
        sum+=array[i];
    }
    return sum;
}



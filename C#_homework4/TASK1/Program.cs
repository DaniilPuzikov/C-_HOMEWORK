// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{a}^{b} = {Degree(a,b)}");

int Degree(int a, int b)
{
    int[] array = new int[b];
    for (int i = 0; i<b; i++)
    {
        array[i] = a;
    }
    int deg = array[0];
    for (int j = 1; j<b; j++)
    {
        deg*=array[j];
    }
    return deg;
}
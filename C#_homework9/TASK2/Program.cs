// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.WriteLine("Введите первое число диапазона");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число диапазона");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"искомая сумма равна {Summa(a,b)}");

int Summa(int a, int b)
{
    if (a==b) return a;
    return Summa(a,b-1) + b;
}

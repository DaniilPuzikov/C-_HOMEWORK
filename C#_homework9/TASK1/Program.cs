// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"



Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(PrintNumbers(a));
string PrintNumbers(int a)
{
    if(a==1) return Convert.ToString(a);
    //return PrintNumbers(a-1) + " " + a;
    return a + ", " + PrintNumbers(a-1);
}
﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y1 = k1 * x + b1, y2 = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Введите значение b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = Convert.ToDouble(Console.ReadLine());
double x = (b1-b2)/(k2-k1);
Console.WriteLine($"Значение x равно {x}");
Console.WriteLine($"Значение y равно {FindY(x)}");

double FindY(double x)
{
    double y1 = k1*x+b1;
    double y2 = k2*x+b2;
    double y = 0;
    if(y1==y2)
        y=y1;
    return y;
}



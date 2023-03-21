// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты первой точки");
Console.Write("x1 = ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("y1 = ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("z1 = ");
double z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("x2 = ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("y2 = ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("z2 = ");
double z2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Расстояние между точками равно {Distanse(x1,y1,z1,x2,y2,z2)}");

double Distanse(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double a = Math.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return a;
}

// Задача 21 - HARD необязательная

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве. Сначала задается N с клавиатуры, потом задаются координаты точек.

Console.WriteLine("Введите число, обозначающее количество координатных осей");
int n = Convert.ToInt32(Console.ReadLine());
double[] array1 = new double[n];
double[] array2 = new double[n];
Console.WriteLine("Введите координаты первой точки");
FillArray(array1,n);
Console.WriteLine("Введите координаты второй точки");
FillArray(array2,n);
Console.WriteLine($"Расстояние между точками равняется {Distanse(array1, array2, n)}");

void FillArray(double[] array,int n)
{
    for (int i=0; i<n; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

double Distanse(double[] array1, double[] array2, int n)
{
    double sum = 0;
    for(int i = 0; i<n; i++)
    {
        sum+=((array2[i]-array1[i])*(array2[i]-array1[i]));
    }
    sum = Math.Sqrt(sum);
    return sum;
}

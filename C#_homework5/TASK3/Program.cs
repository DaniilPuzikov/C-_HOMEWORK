// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
double[] array = new double[a];
FillArray(array);
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {Max(array)-Min(array)}");

void FillArray(double[] array)
{
    Console.WriteLine("Введите значения элементов массива");
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = Convert.ToDouble(Console.ReadLine());
    }
}

double Max(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>max)
            max = array[i];
    }
    return max;
}

double Min(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]<min)
            min = array[i];
    }
    return min;
}
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 5
// 0, 7, 8, -2, -2 -> 2

// 5
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество вводимых чисел");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
FillArray(array);
Console.WriteLine($"Количество чисел больше 0 равно {Count(array)}");


void FillArray(int[] array)
{
    Console.WriteLine("Поочерёдно введите числа");
    for(int i = 0;i<array.Length;i++)
    {
        array[i]=Convert.ToInt32(Console.ReadLine());
    }
}

int Count(int[] array)
{
    int sum = 0;
    for(int i = 0;i<array.Length;i++)
    {
        if(array[i]>0)
            sum++;
    }
    return sum;
}
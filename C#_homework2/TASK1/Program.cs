// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a;
int size = 0;
while(b>0)
{
    b = b/10;
    size++;
}
if(size==3)
{
    b = a;
    b = b/10;
    b = b%10;
    Console.WriteLine($"{b} - вторая цифра числа {a}");
}
else
Console.WriteLine("Введено не трёхзначное число");
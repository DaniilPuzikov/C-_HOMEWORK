// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int b = a;
int size = 0;
while(b>0)
{
    b = b/10;
    size++;
}
b = a;
int[] array = new int[size];
int index = 0;
while(index<size)
{
    array[index] = b%10;
    b=b/10;
    index++;
}
if(size-3<0)
{
    Console.WriteLine("Третьей цифры нет");
}
else
Console.WriteLine($"Третья цифра в числе - это {array[size-3]}");

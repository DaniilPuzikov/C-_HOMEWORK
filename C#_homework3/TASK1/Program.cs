// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());
Palindrom(a);


int Size(int a)
{
    int size=0;
    while(a>0)
    {
        a/=10;
        size++;
    }
    return size;
}

void Palindrom(int a)
{
int b1 = 0;
int b2 = 0;
int b3 = 0;
int b4 = 0;
if (Size(a)==5)
{
    b1 = a/10000;
    b2 = (a/1000)%10;
    b3 = a%10;
    b4 = (a%100)/10;
    if(b1==b3 && b2==b4)
    {
        Console.WriteLine("Введённое число является палиндромом");
    }
    else
    Console.WriteLine("Введённое число не является палиндромом");
}
else
Console.WriteLine("Введено не пятизначное число");
}


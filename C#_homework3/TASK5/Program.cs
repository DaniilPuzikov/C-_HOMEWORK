// Задача 19 - HARD необязательная

// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. Через строку нельзя решать само собой.

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int s = Size(a);
int[] array = new int[s];
CreateArray(array,s);
Check(array, s);



int Size(int a)
{
    int size = 0;
    while(a>0)  
    {
        a=a/10;
        size++;
    }

    return size;
}

void CreateArray(int[] array, int s)
{
    for(int i = 0; i<s; i++)
    {
        array[i] = a%10;
        a/=10;
    }
}

void Check(int[] array, int s)
{
    bool t = true;
    for(int i = 0; i<s; i++)
    {
        for(int j = s-1; j>=0; j--)
        {
            if(array[i]==array[j])
            {
                t = true;
            }
            else
            t = false;
        }
    }
    if (t==true)
    {
        Console.WriteLine("Данное число является палиндромом");
    }
    else
    Console.WriteLine("Данное число не является палиндромом");
}
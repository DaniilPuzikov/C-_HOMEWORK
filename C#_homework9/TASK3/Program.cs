// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое неотрицательное число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе неотрицательное число");
int b = Convert.ToInt32(Console.ReadLine());
if(a>=0 && b>=0)
    Console.WriteLine($"A({a},{b}) = {Akkerman(a,b)}");
else
Console.WriteLine("Введённые числа должны быть неотрицательными");

int Akkerman(int a, int b)
{
    if(a==0) 
    {
        return b+1;
    }
    else if(a!=0 && b==0) 
    {
        return Akkerman(a-1,1);
    }
    else 
    return Akkerman(a-1,Akkerman(a,b-1));
}
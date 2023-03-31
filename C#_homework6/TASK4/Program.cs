// задача 40 - HARD необязательная. На вход программы подаются три целых положительных числа. 
// Определить , является ли это сторонами треугольника. Если да, 
// то вывести всю информацию по нему - площадь, периметр, значения углов треугольника в градусах,
// является ли он прямоугольным, равнобедренным, равносторонним.

Console.WriteLine("Введите размер первой стороны");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите размер второй стороны");
double b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите размер третьей стороны");
double c = Convert.ToDouble(Console.ReadLine());
double[] corners = new double[3];
if(IsReal(a,b,c)==true)
{
    Console.WriteLine($"S = {Square(a,b,c)}");
    Console.WriteLine($"P = {Perimetr(a,b,c)}");
    Console.WriteLine(Types1(a,b,c));
    Console.WriteLine(Types2(a,b,c));
}
else
Console.WriteLine("Такого треугольника не существует");

bool IsReal(double a, double b, double c)
{
    if(a<b+c && b<c+a && c<b+a)
        return true;
    else
    return false;
}

double Square (double a, double b, double c)
{
    double s = 0;
    double p = (a+b+c)/2;
    s = Math.Sqrt(p*(p-a)*(p-b)*(p-c));
    return s;
}

double Perimetr(double a, double b, double c)
{
    return a+b+c;
}

string Types1(double a, double b, double c)
{
    string t = String.Empty;
    if(a*a==b*b+c*c || b*b==a*a+c*c || c*c==a*a+b*b)
        t = "Прямоугольный";
    else t = "Не прямоугольный";
    return t;
}

string Types2(double a, double b, double c)
{
    string t = String.Empty;
    if(a==b && a==c && b==c)
        t = "Равносторонний";
    else 
    if((a==b && a!=c && b!=c)||(a==c && a!=b && b!=c)||(b==c &&  a!=b && a!=c))
        t = "Равноберенный";
    else
    t = "Разносторонний";
    return t;
}




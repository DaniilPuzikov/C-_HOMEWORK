// Задача HARD STAT необязательная: Задайте массив случайных целых чисел. 
// Найдите максимальный элемент и его индекс, минимальный элемент и его индекс, 
// среднее арифметическое всех элементов. Сохранить эту инфу в отдельный массив и вывести на экран с пояснениями. 
// Найти медианное значение первоначалального массива , 
// возможно придется кое-что для этого дополнительно выполнить.



Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
int[] array = new int[a];
double[] answers = new double[6];
FillArray(array);
PrintArray(array);
Answers(answers, Max(array), MaxIndex(array), Min(array), MinIndex(array), Summa(array), a, MedianInt(array),MedianDouble(array));
PrintAnswers(answers);


void FillArray(int[] array)
{
    for(int i = 0; i<array.Length; i++)
    {
        array[i] = new Random().Next(0,101);
    }
}

void PrintArray(int[] array)
{
    Console.Write($"[{array[0]}, ");
    for (int i = 1; i<array.Length-1;i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.Write($"{array[array.Length-1]}]");
    Console.WriteLine();
}

int Max(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>max)
        {
            max = array[i];
        }
            
        
    }
    return max;
}

int Min(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]<min)
            min = array[i];
    }
    return min;
}

int MaxIndex(int[] array)
{
    int maxIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]==Max(array))
        { 
            maxIndex = i;
            break;   
        } 
    }
    return maxIndex;
}

int MinIndex(int[] array)
{
    int minIndex = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]==Min(array))
        {
            minIndex = i;
            break;
        }
            
    }
    return minIndex;
}

int Summa (int[] array)
{
    int sum = 0;
    for(int i = 0; i<array.Length; i++)
    {
        sum+=array[i];
    }
    return sum;
}

int MedianInt(int[] array)
{
    int mid = 0;
    if (array.Length%2!=0)
    {
        mid = array[array.Length/2];
    }
    return mid;
}

double MedianDouble(int[] array)
{
    double mid = 0;
    if(array.Length%2==0)
    {
        mid = (Convert.ToDouble(array[array.Length/2])+Convert.ToDouble(array[array.Length/2]-1))/2;
    }
    return mid;
}
void Answers(double[] answers, int a, int b, int c, int d, int sum, int len, int mid1, double mid2)
{
    answers[0] = Convert.ToDouble(a);
    answers[1] = Convert.ToDouble(b);
    answers[2] = Convert.ToDouble(c);
    answers[3] = Convert.ToDouble(d);
    answers[4] = Convert.ToDouble(sum)/Convert.ToDouble(len);
    if (len%2==0)
    {
        answers[5] = Convert.ToDouble(mid1);
    }
    else
    answers[5] = mid2;
}

void PrintAnswers(double[] answers)
{
    Console.WriteLine($"Максимальный элемент равен {answers[0]}. Его индекс равен {answers[1]}");
    Console.WriteLine($"Минимальный элемент равен {answers[2]}. Его индекс равен {answers[3]}");
    Console.WriteLine($"Среднеe арифметическое элементов массива равно {answers[4]}");
    Console.WriteLine($"Медианное значение элементов массива равно {answers[5]}");
}
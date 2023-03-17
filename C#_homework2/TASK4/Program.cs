// Задача 11 - HARD На входе от пользователя целое число любой разрядности, надо удалить вторую цифру слева направо этого числа.




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
index = 0;
if(size-2<0)
{
    Console.WriteLine("Второй цифры нет");
}
else
while(index<size)
{
   if(array[size-1-index]!=array[size-2])
   {
   Console.Write(array[size-1-index]) ;
   }
   index++;
}

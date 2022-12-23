/*Задайте одномерный массив,
 заполненный случайными числами.
  Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[]FillArray (int length)
{
    int[]arr = new int [length];
    Random rnd = new Random();
    Console.Write("[");
    for(int i = 0; i < length; i++)
    {
        arr[i] = rnd.Next(-100, 100);
        Console.Write(arr[i]+" ");
    }
    return arr;
}

int [] myArray = FillArray(4);
int sum = 0;
for(int i = 0; i < 4; i++)
{
    if(myArray[i] % 2 == 0)
    {
        sum +=0;
    }
    else
    {
        sum += myArray[i];
    }
}
Console.Write("]-> " + sum);
// Написать программу, упорядочивания по убыванию элементов каждой строки двумерного массива.
var array = new int[4, 5];
 
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 100);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
 
var arr = array.Cast<int>().OrderByDescending(a => a).ToArray();
 
int c = 0;
for (int j = 0; j < array.GetLength(0); j++)
{
    for (int k = 0; k < array.GetLength(1); k++)
    {
        array[j, k] = arr[c];
        Console.Write(array[j, k] + " ");
        c++;
    }
    Console.WriteLine();
}


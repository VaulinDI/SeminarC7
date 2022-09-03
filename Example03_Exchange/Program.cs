// Написать программу, которая обменивает элементы первой строки и последней строки
int m = 4;
int n = 5;
int[,] array = new int[m, n];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

int temp = m - 1;
for (int i = 0; i < array.GetLength(1); i++)
{
    int tmp = array[0, i];
    array[0, i] = array[temp, i];
    array[temp, i] = tmp;
}

Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}
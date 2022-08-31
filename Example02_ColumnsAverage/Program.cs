// Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
int m = 4;
int n = 5;
int[,] array = new int[m, n];
int[] sum = new int[n];

void FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 100);
            Console.Write("{0}\t", array[i, j]);
       }
        Console.WriteLine();
    }
}

void ColumnsAverage()
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum = sum + array[j, i];
        }
    Console.WriteLine($"Сумма элементов столбца {i} равна: {sum}");
    sum = 0;
    }
}

FillArray();
ColumnsAverage();
// В прямоугольной матрице найти строку с наименьшей суммой элементов.
int m = 4;
int n = 5;
int[,] array = new int[m, n];

void FillArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write("{0}\t", array[i, j]);
       }
        Console.WriteLine();
    }
}

void ColumnsAverage()
{
    int min = int.MaxValue;
    int count = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j <= array.GetLength(0); j++)
        {
            sum = sum + array[i, j];
        }
    Console.Write($"Сумма элементов строки {i} равна: {sum}   ");
    if (min > sum)
    {
        min = sum;
        count = i;
        Console.Write($"строка с наименьшей суммой элементов: {count}");
    }
    sum = 0;
    Console.WriteLine();
    }
}

FillArray();
ColumnsAverage();
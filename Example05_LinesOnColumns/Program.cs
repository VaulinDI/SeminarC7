// Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить,
// что это невозможно (в случае, если матрица не квадратная).
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

Console.WriteLine();

if (m != n)
{
    Console.WriteLine("Заменить строки на столбцы не получится. Матрица не квадратная");
}
else
{
for (int i = 0; i < array.GetLength(0); i++)
{    
    for (int j = 0; j < array.GetLength(1); j++)
    {
        Console.Write(array[j, i] + "\t");
    }
    Console.WriteLine();
}
}
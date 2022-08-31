// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет
int m = 4;
int n = 5;
int[,] array = new int[m, n];

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

FillArray();
Console.WriteLine("Введите число: ");
int x = Convert.ToInt32(Console.ReadLine());

void NumberPosition()
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
       {
           if (x == array[i, j])
            {
                Console.WriteLine($"Введенное число находится в строке {i} и столбце {j}");
                count++;
            }       
        }
    }
    if (count == 0)
    {
        Console.WriteLine("Введенного числа нет в массиве");
    }
}

NumberPosition();
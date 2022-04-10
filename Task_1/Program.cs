// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] array = RandomArray(5,5);	
PrintArray(array);


double[,] RandomArray (int row, int column)
{
    double[,] array = new double[row,column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = -10 + new Random().NextDouble() * 100;
        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]: 0.000}\t");
        }
        Console.WriteLine();
    }
}

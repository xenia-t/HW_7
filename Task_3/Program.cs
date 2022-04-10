// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

int[,] array = RandomArray(3,4);
Console.WriteLine();	
PrintArray(array);

double[] average = FindAverage(array);
Console.Write("Среднее арифметическое в каждом столбце:");
PrintAverage(average);



int[,] RandomArray (int row, int column)
{
    int[,] array = new int[row,column];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(1,10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine("\n");
    }
}

double[] FindAverage (int[,] array)
{
    double[] average = new double[array.GetLength(1)];
    double sum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        average [j] = sum / array.GetLength(0);
        sum = 0;        
    }
    return average;
}

void PrintAverage(double[] average)
{
    foreach (double digit in average)
    {
        Console.Write($"{digit: 0.0} ");
    }
}
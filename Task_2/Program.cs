// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


int row = Promt("\nВведите значение позицию элемента в строке: ");
int column = Promt("Введите значение позиции элемента в столбце: ");

if (row > 0 && column > 0)
{
    int[,] array = RandomArray(3,4);	
    PrintArray(array);
    FindElem(array, row, column);
}

else Console.WriteLine("\nПозиция элемента в строке или столбце не может принимать отрицательные значения или равняться 0\n");


int Promt(String message)
{
    Console.Write(message);
    string strValue = Console.ReadLine();
    int Value = int.Parse(strValue);
    return Value;
}

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
        Console.WriteLine();
    }
}


void FindElem (int[,] array, int row, int column)
{
    if (row <= array.GetLength(0) && column <= array.GetLength(1))
    {
        Console.WriteLine($"\nПозиции ({row},{column}) соответствует элемент со значение {array[(row-1),(column-1)]}\n");
    }
    else Console.WriteLine($"\nТакого элемента в массиве нет\n");
}




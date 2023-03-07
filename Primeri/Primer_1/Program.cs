// Задача 1: Задайте двумерный массив. Напишите программу, 
// которая поменяет местами первую и последнюю строку массива.

int [,] GenerateArray(int r, int c)
{
    int[,] array = new int[r, c]; 
    Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = random.Next(-9, 10);
        }
    }
    return array;
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]}\t");
        }
    }
    Console.WriteLine();
}

int [,] MoveFirstLast(int[,] array)
{
    int LastRow = array.GetLength(0) - 1;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        (array[LastRow, i],array[0,i]) = (array[0, i], array[LastRow, i]); // зеркальное изменение
    }
    return array;
}

int [,] MyArray = GenerateArray(5, 6);
PrintArray(MyArray);
System.Console.WriteLine();
PrintArray(MoveFirstLast(MyArray));
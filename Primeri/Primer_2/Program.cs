// Задача 2: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.
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

int [,] Transport (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = i; j < array.GetLength(1); j++)
        {
            (array[i, j],array[j, i]) = (array[j, i], array[i, j]);
        }
    }
    return array;
}

bool Validete(int [,] array)
{
    if (array.GetLength(0) == array.GetLength(1))
    {
        return true;
    }
    return false;
}

int [,] MyArray = GenerateArray(5, 5);
PrintArray(MyArray);
if (Validete(MyArray))
{
    PrintArray(Transport(MyArray));
}